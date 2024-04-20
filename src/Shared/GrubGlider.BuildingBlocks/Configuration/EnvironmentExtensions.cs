using Microsoft.Extensions.Configuration;

namespace GrubGlider.BuildingBlocks.Configuration;

public static class EnvironmentExtensions
{
    private const string EnvironmentSection = "ASPNETCORE_ENVIRONMENT";

    public static bool IsDevelopment(this IConfiguration configuration) =>
        configuration.GetEnvironment() == "Development";

    public static bool IsStaging(this IConfiguration configuration) =>
        configuration.GetEnvironment() == "Staging";

    public static bool IsProduction(this IConfiguration configuration) =>
        configuration.GetEnvironment() == "Production";

    private static string GetEnvironment(this IConfiguration configuration)
    {
        var environment = configuration[EnvironmentSection] ??= "Development";
        return environment;
    }

}