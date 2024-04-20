using Microsoft.Extensions.DependencyInjection;

namespace GrubGlider.BuildingBlocks.Api;

public static class CorsPolicyExtension
{
    public const string PolicyName = "CorsPolicy";

    public static void AddCorsPolicy(this IServiceCollection services) =>
        services.AddCors(options => {
            options.AddPolicy(PolicyName,
                builder => builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin());
        });
}