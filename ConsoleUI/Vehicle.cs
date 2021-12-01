using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        //Properties
        public string Year { get; set; } = "Default Year";
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";


        //No Implementation
        public abstract void DriveAbstract();


        //Base Implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Vehicle is in drive");
        }      
    }

}
