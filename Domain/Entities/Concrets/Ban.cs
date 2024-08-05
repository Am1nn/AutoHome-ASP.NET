using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Ban : BaseEntity
{
    public string? BanType { get; set; }



    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
