using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Marka : BaseEntity
{
    public string? MarkaType { get; set; }


    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }

}
