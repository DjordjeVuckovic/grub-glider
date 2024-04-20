using System.Text.Json.Serialization;
using GrubGlider.OfferingService.Restaurants.Types;

namespace GrubGlider.OfferingService.Menus.Types;

public class MenuDao
{
    public Guid Id { get; init; }
    public string Description { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public Restaurant Restaurant { get; init; }
    
    [JsonConstructor]
    public MenuDao()
    {
    }

    public MenuDao(string name, string description, Restaurant restaurant)
    {
        Description = description;
        Name = name;
        Restaurant = restaurant;
    }
}