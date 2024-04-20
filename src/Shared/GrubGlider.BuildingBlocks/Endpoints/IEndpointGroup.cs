using Microsoft.AspNetCore.Routing;

namespace GrubGlider.BuildingBlocks.Endpoints;

public interface IEndpointGroup
{
    void AddRoutes(IEndpointRouteBuilder app);
}