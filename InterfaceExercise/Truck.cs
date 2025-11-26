using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasBed { get; set; }
        public double BedLength { get; set; }
        public int NumberOfWheels { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Profits { get; set; }
        public int Losses { get; set; }
    }
    

    
}
