using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrets
{
    public class Status:BaseEntity
    {
        public string? StatusType { get; set; }
    }
}
