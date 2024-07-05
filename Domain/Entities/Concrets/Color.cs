using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrets
{
    public class Color:BaseEntity
    {
        public string? Name { get; set; }
    }
}
