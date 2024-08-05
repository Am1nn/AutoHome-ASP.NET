using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Fuel:BaseEntity
{
    public string? FuelType { get; set; }



    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
