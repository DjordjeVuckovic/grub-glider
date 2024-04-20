using GrubGlider.OfferingService.GrubItems.Types;
using GrubGlider.OfferingService.Menus.Types;
using GrubGlider.OfferingService.Persistence.Options;
using Marten;
using Marten.Schema.Identity;
using Microsoft.Extensions.Options;
using Weasel.Core;

namespace GrubGlider.OfferingService.Persistence.Extensions;

public static class DependencyInjection
{
    public static void AddPersistence(this IServiceCollection services, bool shouldAutoMigrate)
    {
        services.AddMarten(options =>
        {
            var dbOptions = services.BuildServiceProvider().GetRequiredService<IOptions<DatabaseOptions>>().Value;

            options.Connection(dbOptions.ConnectionString!);
            options.DatabaseSchemaName = dbOptions.Schema!;
            
            options.UseNewtonsoftForSerialization(
                enumStorage: EnumStorage.AsString,
                casing: Casing.SnakeCase,
                collectionStorage: CollectionStorage.AsArray
            );
            
            options.Policies.ForAllDocuments(x =>
            {
                if (x.IdType == typeof(Guid))
                {
                    x.IdStrategy = new CombGuidIdGeneration();
                }
            });
            
            if (shouldAutoMigrate)
            {
                options.AutoCreateSchemaObjects = AutoCreate.All;
            }

            options.AddEntities();
        })
            .OptimizeArtifactWorkflow()
            .ApplyAllDatabaseChangesOnStartup();
    }

    private static void AddEntities(this StoreOptions opts)
    {
        opts.Schema.For<MenuDao>()
            .Identity(x => x.Id)
            .UseOptimisticConcurrency(true)
            .SoftDeleted();
        
        opts.Schema.For<GrubItemDao>()
            .Identity(x => x.Id)
            .ForeignKey<MenuDao>(x => x.MenuId)
            .SoftDeleted();
    }
}