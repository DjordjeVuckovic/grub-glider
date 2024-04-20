using System.Reflection;
using Microsoft.AspNetCore.Routing;

namespace GrubGlider.BuildingBlocks.Endpoints;

public static class Extensions
{
    public static void MapEndpoints(this IEndpointRouteBuilder app, IEnumerable<Assembly> assemblies)
    {
        var types = assemblies.SelectMany(x => x.GetTypes()).ToArray();
        var endpointGroupTypes = types
            .Where(t => typeof(IEndpointGroup).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
            .ToList();

        foreach (var endpointInstance in endpointGroupTypes.Select(type =>
                     Activator.CreateInstance(type) as IEndpointGroup)) {
            endpointInstance?.AddRoutes(app);
        }
    }
    
    
    public static void MapEndpoints(this IEndpointRouteBuilder app, Assembly assembly)
    {
        var types = assembly.GetTypes();
        var endpointGroupTypes = types
            .Where(t => typeof(IEndpointGroup).IsAssignableFrom(t) && t is { IsInterface: false, IsAbstract: false })
            .ToList();

        foreach (var endpointInstance in endpointGroupTypes.Select(type =>
                     Activator.CreateInstance(type) as IEndpointGroup)) {
            endpointInstance?.AddRoutes(app);
        }
    }
}