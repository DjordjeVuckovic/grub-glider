using CSharpFunctionalExtensions;

namespace GrubGlider.BuildingBlocks.Domain;

public record Price(decimal Amount, string Currency = "EUR")
{
    public static Result<Price> Create(decimal value)
    {
        if (value <= 0)
        {
            return Result.Failure<Price>("Price must be greater than zero.");
        }
        return new Price(value);
    }
    
    public static Result<Price> Create(decimal value, string currency)
    {
        if (value <= 0)
        {
            return Result.Failure<Price>("Price must be greater than zero.");
        }
        return new Price(value, currency);
    }
}