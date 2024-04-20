using Microsoft.Extensions.Options;

namespace GrubGlider.OfferingService.Persistence.Options;

public class DatabaseOptions : IValidateOptions<DatabaseOptions>
{
    public const string Database = nameof(Database);
    public string? ConnectionString { get; set; }
    public string? Schema { get; set; }
    
    public ValidateOptionsResult Validate(string? name, DatabaseOptions options)
    {
        if (options.ConnectionString is null)
        {
            return ValidateOptionsResult.Fail("ConnectionString is required.");
        }
        if (options.Schema is null)
        {
            return ValidateOptionsResult.Fail("Schema is required.");
        }
        return ValidateOptionsResult.Success;
    }
}