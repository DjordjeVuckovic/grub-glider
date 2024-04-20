using CSharpFunctionalExtensions;
using GrubGlider.BuildingBlocks.Api;
using GrubGlider.BuildingBlocks.Api.Responses;
using GrubGlider.BuildingBlocks.Endpoints;
using GrubGlider.OfferingService.Menus.Types;
using GrubGlider.OfferingService.Restaurants.Types;
using Marten;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GrubGlider.OfferingService.Menus;

internal record CreteMenuRequest(
    string Name,
    string Description,
    Restaurant Restaurant
);

public class CreateMenuEndpoint : IEndpointGroup
{
    private const string Route = "/api/v1/menus";

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost(Route, async (
                [FromServices] ISender sender,
                [FromBody] CreteMenuRequest request) =>
            {
                var createFoodCommand = new CreateMenuHandler.Command(
                    request.Name,
                    request.Description,
                    request.Restaurant
                );
                var result = await sender.Send(createFoodCommand);
                return result.ToSuccessOrBadRequest(
                    id => Results.Created($"{Route}/{id}", new CreateResponse<Guid>(id))
                );
            })
            .WithName("CreateMenu")
            .WithOpenApi();
    }
}

internal class CreateMenuHandler(IDocumentStore store) : IRequestHandler<CreateMenuHandler.Command, Result<Guid>>
{
    private readonly IDocumentSession _session = store.LightweightSession();
    internal record Command(
        string Name,
        string Description,
        Restaurant Restaurant
    ) : IRequest<Result<Guid>>;

    public async Task<Result<Guid>> Handle(Command request, CancellationToken cancellationToken)
    {
        var menu = new MenuDao(request.Name, request.Description, request.Restaurant);
        
        _session.Insert(menu);
        await _session.SaveChangesAsync(cancellationToken);
        return Result.Success(menu.Id);
    }
}