using System.Text.Json.Serialization;

namespace GrubGlider.OfferingService.Restaurants.Types;

public class Restaurant
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Location { get; init; }
    
    [JsonConstructor]
    public Restaurant(Guid id, string name, string location)
    {
        Id = id;
        Name = name;
        Location = location;
    }
}