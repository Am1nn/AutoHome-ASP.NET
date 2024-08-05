namespace Domain.Entities.Concrets;

public class Status
{
    public string? CarStatus { get;set; }


    //Navigation Property

    public ICollection<Vehicle>? Vehicles { get; set; }
}
