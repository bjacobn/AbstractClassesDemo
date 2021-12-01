using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        //Constructor
        public Car()
        {

        }

        //Distinct property 
        public bool HasSteeringWheel { get; set; }


        //Implementation
        public override void DriveAbstract()
        {
            Console.WriteLine("Abstract Car is in drive");
        }
    }
}
