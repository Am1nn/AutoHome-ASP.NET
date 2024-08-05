using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class OrignCountry:BaseEntity
{
    public string? Country {  get; set; }

    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
