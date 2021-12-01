using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public Car()
        {

        }

        public bool HasSteeringWheel { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("Car is in drive");
        }
    }
}
