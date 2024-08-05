using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Seller:BaseEntity
{
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? RePassword { get; set; }
    public bool? IsVerificated { get; set; } = false;
    public bool? AllowNews { get; set; } = false;

    public string? LogoUrl { get; set; }

    //Foreign Key
    public int PlaceId { get; set; }

    //Navigation Property
    public Place? Place { get; set; }
    public ICollection<Vehicle>? Vehicles { get; set; }
    public ICollection<Plate>? Plates { get; set; }
    public ICollection<Phone>? Phones { get; set; }
}
