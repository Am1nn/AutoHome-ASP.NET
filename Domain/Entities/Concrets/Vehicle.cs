using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Vehicle:BaseEntity
{
    public ICollection<string?>? VehicleImageUrls { get; set; }
    public long Mileage { get;set; }    
    public int HorsePower { get; set; }
    public bool? IsPremium { get; set; } = false;
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
    public int StatusId { get; set; }
    public int MarkaId { get; set; }
    public int ModelId { get; set; }
    public int BanId { get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmitterId { get; set; }
    public int GearboxId { get; set; }
    public int OrignCountryId { get; set; }

    //Navigation Property
    public Dealership? Dealership { get;set; }
    public Seller? Seller { get;set; }
    public Status? Status { get; set; }
    public Marka? Marka { get; set; }
    public Model? Model { get; set; }
    public Ban? Ban { get; set; }
    public Color? Color { get; set; }
    public Fuel? Fuel { get; set; }
    public Transmitter? Transmitter { get; set; }
    public Gearbox? Gearbox { get; set; }
    public OrignCountry? OrignCountry { get; set; }
    public ICollection<VehicleAdditional>? VehicleAdditionals { get; set;}
}
