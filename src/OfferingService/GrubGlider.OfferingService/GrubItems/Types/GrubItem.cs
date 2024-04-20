using Newtonsoft.Json;
using CSharpFunctionalExtensions;
using GrubGlider.BuildingBlocks.Domain;

namespace GrubGlider.OfferingService.GrubItems.Types;

public class GrubItem
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public Price Price { get; init; }


    private GrubItem(string name, string description, Price price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
    
    public GrubItem(Guid id, string name, string description, Price price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
    }

    [JsonConstructor]
    public GrubItem()
    {
    }
    
    
    public static Result<GrubItem> Create(string name, string description, decimal price, string currency)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || price <= 0)
        {
            return Result.Failure<GrubItem>("Failed to validate provided data.");
        }

        var priceOrErr = Price.Create(price, currency);
        if (priceOrErr.IsFailure)
        {
            return Result.Failure<GrubItem>(priceOrErr.Error);
        }

        return new GrubItem(name, description, priceOrErr.Value);
    }
}