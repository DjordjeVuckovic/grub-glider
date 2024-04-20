using System.Reflection;
using GrubGlider.BuildingBlocks.Configuration;
using GrubGlider.OfferingService.Persistence.Options;

namespace GrubGlider.OfferingService.Extensions;

public static class DependencyInjection
{
    public static void AddMediator(this IServiceCollection services)
    {
        services.AddMediatR(config =>
            config.RegisterServicesFromAssembly(typeof(Program).Assembly));
    }

    public static void AddOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .BindOption<DatabaseOptions>(configuration, DatabaseOptions.Database);
    }
}