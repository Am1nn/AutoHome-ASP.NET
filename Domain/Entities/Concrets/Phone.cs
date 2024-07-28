using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Phone:BaseEntity
{
    public string? PhoneNumber { get; set; }

    //Foregin key
    public int SellerId { get; set; }  
    public int DealershipId {  get; set; }

    //Navigation Property
    public Seller? Seller { get; set; }
    public Dealership? Dealership { get; set; }
}
