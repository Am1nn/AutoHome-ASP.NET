using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Vehicle:BaseEntity
{
    public ICollection<string?>? VehicleImageUrls { get; set; }
    public long Mileage { get;set; }    
    public int HorsePower { get; set; }
    public bool? IsPremium { get; set; } = false;
    public bool? IsNew { get; set; } = false;
    public bool? IsCredit { get; set; } = false;
    public bool? IsChangable { get; set; } = false;
    public bool? IsDealership { get; set; } = false;

    public int SeatCounts { get; set; }
    public string? VIN { get; set; }
    public string? Description { get; set; }    
    public decimal? Price { get; set; }

    //Foreign Key
    public int DealershipId { get;set;}
    public int SellerId { get;set;}

    //Navigation Property
    public Dealership? Dealership { get;set; }
    public Seller? Seller { get;set; }


}
