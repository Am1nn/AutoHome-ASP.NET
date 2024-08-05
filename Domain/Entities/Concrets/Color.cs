using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Color : BaseEntity
{
    public string? ColorType { get; set; }


    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
