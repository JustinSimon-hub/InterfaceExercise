using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle    
    {
        public int NumberOfWheels { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }

    }
}


//In your IVehicle:

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: public int NumberOfWheels { get; set; }
 */