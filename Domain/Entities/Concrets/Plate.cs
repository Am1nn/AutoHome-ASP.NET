using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Plate:BaseEntity
{
    public string? NumberPlate { get; set; }
    public string? Description { get; set; }
    public bool? IsPremium { get; set; }=false;

    public decimal Price { get; set; }

    //Foreign Key
    public int SellerId { get; set; }

    //Navigation Property
    public Seller? Seller { get; set; }
}
