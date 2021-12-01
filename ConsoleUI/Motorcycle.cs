using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        //Constructor
        public Motorcycle()
        {

        }

        //Distinct Property 
        public bool HasHandleBars { get; set; }


        //Implemention 
        public override void DriveAbstract()
        {
            Console.WriteLine("Abstract Motorcyle is in drive");
        }


        //Derived method override Base Method
        public override void DriveVirtual()
        {
            Console.WriteLine("Virtual Motorcyle is not in drive");
        }
    }
}  
