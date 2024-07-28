using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Ban:BaseEntity
{
    public string? BanType { get; set; }
}
