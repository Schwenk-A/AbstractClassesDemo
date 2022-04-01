using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public Vehicles()
        {

        }
        public int Year { get; set; } = 1990;
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";
        public abstract void DriveHornSoundAbstract();

        public virtual void DriveCarSoundVirtual()
        {
            Console.WriteLine("Vroom?");
        }
        
    }
}
