using System;
using System.Collections.Generic;
using System.Reflection;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV




            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            List<object> Vehicles = new List<object>()
        {

            new Car
            {
                HasBed = false,
                NumberOfSeats = 5,
                Profits = 1000000,
                Losses = 50000,
                NumberOfWheels = 4,
                Brand = "Toyota",
                Color = "Red",
                CountryOfOrigin = "Japan"
            },

           new Truck
            {
                HasBed = true,
                BedLength = 2,
                Profits = 2000000,
                Losses = 100000,
                NumberOfWheels = 6,
                Brand = "Ford",
                Color = "Blue",
                CountryOfOrigin = "USA"
            },

          new SUV
            {
                IsLarge = true,
                OffRoadCapable = true,
                Profits = 1500000,
                Losses = 75000,
                NumberOfWheels = 4,
                Brand = "Honda",
                Color = "Black",
                CountryOfOrigin = "Japan"
            }
        };


            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"Types: {vehicle.GetType().Name}");
                foreach (PropertyInfo prop in vehicle.GetType().GetProperties())
                {
                    Console.WriteLine($"{prop.GetValue(vehicle)}");
                }
                Console.WriteLine("----------------------");

            }
        }
    }
}


