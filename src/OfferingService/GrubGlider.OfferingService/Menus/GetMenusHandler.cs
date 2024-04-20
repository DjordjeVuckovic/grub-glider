using GrubGlider.BuildingBlocks.Endpoints;
using GrubGlider.OfferingService.GrubItems.Factories;
using GrubGlider.OfferingService.GrubItems.Types;
using GrubGlider.OfferingService.Menus.Types;
using Marten;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GrubGlider.OfferingService.Menus;

public class GetMenusEndpoint : IEndpointGroup
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/v1/menus", async (
                [FromServices] ISender sender) =>
            {
                var query = new GetMenusHandler.Query();
                var result = await sender.Send(query);
                return result;
            })
            .WithName("GetMenus")
            .WithOpenApi();
    }
}

internal class GetMenusHandler(IDocumentStore store, ILogger<GetMenusHandler> logger) : IRequestHandler<GetMenusHandler.Query, IEnumerable<Menu>>
{
    private readonly IQuerySession _session = store.QuerySession();

    internal record Query : IRequest<IEnumerable<Menu>>;

    public async Task<IEnumerable<Menu>> Handle(Query request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Fetching all menus ...");
        var menus = new List<MenuDao>();

        var query = _session
            .Query<GrubItemDao>()
            .Include(x => x.MenuId, menus);
        
        var items = await query
            .ToListAsync(cancellationToken)
            .ConfigureAwait(false);

        return menus.Select(menu => new Menu
        {
            Id = menu.Id,
            Name = menu.Name,
            Description = menu.Description,
            Restaurant = menu.Restaurant,
            GrubItems = items.Where(x => x.MenuId == menu.Id).Select(GrubItemFactory.ToDomain)
        });
    }
}