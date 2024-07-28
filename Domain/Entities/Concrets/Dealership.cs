using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Dealership:BaseEntity
{
    public string? Name {  get; set; }
    public string? Email { get; set; }
    public string? Description { get; set; }
    public string? Slogan {  get; set; }
    public string? LogoUrl { get; set; }    
    public string? BannerUrl { get; set; }
    public bool IsOficcial { get; set; } = false;


    //Foreign Key
    public int PlaceId { get; set; }

    //Navigation Property
    public Place? Place { get; set; }
    public ICollection<Vehicle>? Vehicles { get; set; }
    public ICollection<Phone>? Phones { get; set; } 

}
