using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Routing;

namespace GrubGlider.BuildingBlocks.Api;

public static class HealthChecksExtension
{
    public static void AddHealthinessChecks(this IEndpointRouteBuilder app)
    {
        app.MapHealthChecks("/health/ready", new HealthCheckOptions {
            Predicate = check => check.Tags.Contains("ready")
        });

        app.MapHealthChecks("/health/live", new HealthCheckOptions());
    }
}