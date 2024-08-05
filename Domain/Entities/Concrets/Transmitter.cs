using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Transmitter : BaseEntity
{
    public string? Transmission { get; set; }


    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
