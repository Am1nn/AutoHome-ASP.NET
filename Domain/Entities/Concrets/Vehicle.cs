using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrets
{
    public class Vehicle:BaseEntity
    {
        public int Mileage { get; set; }
        public int Year { get; set; }
        public int EngineVolume {  get; set; }
        public int EnginePower { get; set; }
        public short SeatsCount { get; set; }
        public string? VIN { get; set; }
        public string? Description { get; set; }
        

        public bool IsDamaged { get; set; }=false;
        public bool IsCrushed {  get; set; }=false; 
        public bool IsBrushed { get; set; }=false;  
        public bool IsChangable { get; set; }=false;
        public bool IsPremium { get; set; } = false;

    }
}
