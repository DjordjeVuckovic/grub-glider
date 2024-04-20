using GrubGlider.BuildingBlocks.Domain;
using GrubGlider.OfferingService.GrubItems.Types;

namespace GrubGlider.OfferingService.GrubItems.Factories;

public static class GrubItemFactory
{
    public static GrubItemDao ToDao(GrubItem item, Guid menuId) => new(
        item.Name,
        item.Description,
        item.Price.Amount,
        item.Price.Currency,
        menuId
    );
    
    public static GrubItem ToDomain(GrubItemDao item) => new(
        item.Id,
        item.Name,
        item.Description,
        new Price(item.PriceAmount, item.PriceCurrency)
    );
}