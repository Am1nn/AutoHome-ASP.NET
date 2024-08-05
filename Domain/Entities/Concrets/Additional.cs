using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Additional : BaseEntity
{
    public string? Name { get; set; }


    //Navigation Property

    public ICollection<VehicleAdditional>? VehicleAdditionals { get; set; }

}
