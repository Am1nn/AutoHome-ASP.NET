using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Place:BaseEntity
{
    public string? PlaceName { get; set; }

    //Navigation Property
    public ICollection<Dealership>? Dealerships { get; set; }
    public ICollection<Seller>? Sellers { get; set; }
}
