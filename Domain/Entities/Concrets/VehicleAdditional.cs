using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class VehicleAdditional : BaseEntity
{
    //Foreign Key
    public int VehicleId { get; set; }
    public int AdditionalId { get; set; }
    //Navigation Property
    public Vehicle? Vehicle { get; set; }
    public Additional? Additional { get; set; }

}
