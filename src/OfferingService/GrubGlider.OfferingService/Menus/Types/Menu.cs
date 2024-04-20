using GrubGlider.OfferingService.GrubItems.Types;
using GrubGlider.OfferingService.Restaurants.Types;
using Newtonsoft.Json;

namespace GrubGlider.OfferingService.Menus.Types;

public class Menu
{
    public Guid Id { get; init; }
    public string Description { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    // tell marten to ignore this property when writing to the database
    // [JsonIgnore]
    public IEnumerable<GrubItem> GrubItems { get; init; } = Enumerable.Empty<GrubItem>();
    public Restaurant Restaurant { get; init; }
    
    public Menu()
    {
    }

    public Menu(Guid id, string name, string description, Restaurant restaurant, IEnumerable<GrubItem> items)
    {
        Id = id;
        Description = description;
        Name = name;
        Restaurant = restaurant;
        GrubItems = items;
    }
}