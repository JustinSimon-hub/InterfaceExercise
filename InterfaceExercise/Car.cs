using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public bool HasBed { get; set; }
        public int NumberOfSeats { get; set; }
        public int Profits { get; set; }
        public int Losses { get; set; }
        public int NumberOfWheels { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }
    }
}


//In each of your Car, Truck, and SUV classes

/* Create 2 members that are specific to each class
 * Example for Car: public bool HasTrunk { get; set; }
 * Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */