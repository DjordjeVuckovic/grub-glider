using System.Text.Json.Serialization;
using GrubGlider.OfferingService.Restaurants.Types;

namespace GrubGlider.OfferingService.Menus.Types;

public class MenuDao
{
    public Guid Id { get; init; }
    public string Description { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public Restaurant Restaurant { get; init; }
    
    public List<Guid> Items { get; set; } = Enumerable.Empty<Guid>().ToList();
    
    [JsonConstructor]
    public MenuDao()
    {
    }

    public MenuDao(string name, string description, Restaurant restaurant, List<Guid> items)
    {
        Description = description;
        Name = name;
        Restaurant = restaurant;
        Items = items;
    }
}