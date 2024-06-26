﻿using CSharpFunctionalExtensions;
using GrubGlider.BuildingBlocks.Api;
using GrubGlider.BuildingBlocks.Api.Responses;
using GrubGlider.BuildingBlocks.Endpoints;
using GrubGlider.OfferingService.GrubItems.Factories;
using GrubGlider.OfferingService.GrubItems.Types;
using GrubGlider.OfferingService.Menus.Types;
using Marten;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GrubGlider.OfferingService.Menus;

public class GetMenuEndpoint : IEndpointGroup
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/menus/{id:guid}", async (
                [FromServices] ISender sender,
                Guid id) =>
            {
                var query = new GetMenuHandler.Query(id);
                var result = await sender.Send(query);
                return result.ToSuccessOrNotFound();
            })
            .WithName("GetMenu")
            .WithOpenApi();
    }
}

internal class GetMenuHandler(IDocumentStore store, ILogger<GetMenuHandler> logger) : IRequestHandler<GetMenuHandler.Query, Result<Menu>>
{
    private readonly IQuerySession _session = store.QuerySession();

    internal record Query(Guid Id) : IRequest<Result<Menu>>;

    public async Task<Result<Menu>> Handle(Query request, CancellationToken cancellationToken)
    {
        var items = new List<GrubItemDao>();
        var menu = await _session
            .Query<MenuDao>()
            .Include(x => x.Items, items)
            .FirstOrDefaultAsync(x => x.Id == request.Id,cancellationToken);

        if (menu is null)
        {
            logger.LogError("Menu with id {Id} not found", request.Id);
            return Result.Failure<Menu>($"Menu with id {request.Id} not found");
        }

        return new Menu
        {
            Id = menu.Id,
            Name = menu.Name,
            Description = menu.Description,
            Restaurant = menu.Restaurant,
            GrubItems = items.Select(GrubItemFactory.ToDomain)
        };
    }
}