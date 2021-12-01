using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle()
        {

        }

        public bool HasHandleBars { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcyle is in drive");
        }


        //Use this derived method to override base method
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcyle is not in drive");
        }
    }
}  
