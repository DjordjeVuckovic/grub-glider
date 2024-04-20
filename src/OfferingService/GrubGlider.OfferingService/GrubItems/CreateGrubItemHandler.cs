using CSharpFunctionalExtensions;
using GrubGlider.BuildingBlocks.Api;
using GrubGlider.BuildingBlocks.Api.Responses;
using GrubGlider.BuildingBlocks.Endpoints;
using GrubGlider.OfferingService.GrubItems.Factories;
using GrubGlider.OfferingService.GrubItems.Types;
using Marten;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GrubGlider.OfferingService.GrubItems;

public record CreateGrubItemRequest(
    string Name,
    string Description,
    decimal Price,
    string? Currency,
    Guid MenuId
);

public class CreateGrubItemEndpoint : IEndpointGroup
{
    private const string Route = "/api/v1/food-items";

    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost(Route, async (
                [FromServices] ISender sender,
                [FromBody] CreateGrubItemRequest request) =>
            {
                var createFoodCommand = new CreateGrubItemHandler.Command(
                    request.Name,
                    request.Description,
                    request.Price,
                    request.Currency ?? "EUR",
                    request.MenuId
                );
                var result = await sender.Send(createFoodCommand);
                return result.ToSuccessOrBadRequest(
                    id => Results.Created($"{Route}/{id}", new CreateResponse<Guid>(id))
                );
            })
            .WithName("CreateGrubItem")
            .WithOpenApi();
    }
}

internal class CreateGrubItemHandler(IDocumentStore store)
    : IRequestHandler<CreateGrubItemHandler.Command, Result<Guid>>
{
    private readonly IDocumentSession _session = store.LightweightSession();

    internal record Command(
        string Name,
        string Description,
        decimal Price,
        string Currency,
        Guid MenuId
    ) : IRequest<Result<Guid>>;

    public async Task<Result<Guid>> Handle(Command request, CancellationToken cancellationToken)
    {
        var itemOrError = GrubItem.Create(
            request.Name,
            request.Description,
            request.Price,
            request.Currency
        );
        return await itemOrError.Bind(async x =>
        {
            var dao = GrubItemFactory.ToDao(x, request.MenuId);
            _session.Insert(dao);
            await _session.SaveChangesAsync(cancellationToken);
            return Result.Success(dao.Id);
        });
    }
}