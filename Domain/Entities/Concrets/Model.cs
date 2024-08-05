using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Model : BaseEntity
{
    public string? ModelType { get; set; }

    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
