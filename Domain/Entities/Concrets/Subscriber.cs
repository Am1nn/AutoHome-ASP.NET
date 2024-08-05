using Domain.Entities.Abstracts;

namespace Domain.Entities.Concrets;

public class Subscriber:BaseEntity
{
    public string? Email { get; set; }

}
