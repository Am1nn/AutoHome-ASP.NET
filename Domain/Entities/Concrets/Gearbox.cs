using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Gearbox:BaseEntity
{
    public string? GearType { get;set; }


    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
