using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE- Provide the implementations for the abstract methods
             * DONE- Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();


            /*
             * DONE- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * DONE - new it up as one of each derived class
             * DONE- Set the properties with object initializer syntax
             */

            var ford = new Car()
            {
                Year = "2021",
                Make = "Ford",
                Model = "Fusion",
                HasSteeringWheel = true
            };



            var yamaha = new Motorcycle()
            {
                Year = "2020",
                Make = "Yamaha",
                Model = "YZF-R3",
                HasHandleBars = true
            };


            Vehicle honda = new Car()
            {
                Year = "2021",
                Make = "Honda",
                Model = "Accord",
                HasSteeringWheel = true
            };

            Vehicle suzuki = new Motorcycle()
            {
                Year = "2021",
                Make = "Suzuki",
                Model = "XL-5",
                HasHandleBars = true
            };


            /*
             * DONE - Add the 4 vehicles to the list
             * DONE - Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(ford);
            vehicles.Add(yamaha);
            vehicles.Add(honda);
            vehicles.Add(suzuki);


            foreach (var specs in vehicles)
            {
                Console.WriteLine($"Year : {specs.Year}   Make : {specs.Make}  Model : {specs.Model}");

                specs.DriveVirtual();
     
                Console.WriteLine("-------------------------------------------");
            }


            // Call each of the drive methods for one car and one motorcycle


            ford.DriveAbstract();
            ford.DriveVirtual();

            yamaha.DriveAbstract();
            yamaha.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
