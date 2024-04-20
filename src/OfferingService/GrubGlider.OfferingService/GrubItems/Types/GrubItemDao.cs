using System.Text.Json.Serialization;
using CSharpFunctionalExtensions;
using GrubGlider.BuildingBlocks.Domain;

namespace GrubGlider.OfferingService.GrubItems.Types;

public class GrubItemDao
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public decimal PriceAmount { get; init; }
    public string PriceCurrency { get; init; }

    public Guid MenuId { get; init; }

    public GrubItemDao(string name, string description, decimal priceAmount,string priceCurrency, Guid menuId)
    {
        Name = name;
        Description = description;
        PriceAmount = priceAmount;
        PriceCurrency = priceCurrency;
        MenuId = menuId;
    }

    [JsonConstructor]
    public GrubItemDao()
    {
    }
}