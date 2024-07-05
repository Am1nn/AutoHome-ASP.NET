using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrets
{
    public class Dealership:BaseEntity
    {
        public string? Name { get; set; } 
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }
        public string? ImgUrl {  get; set; }

    }
}
