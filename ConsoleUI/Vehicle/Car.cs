using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Vehicle
{
    public class Car: Vehicles
    {
        public Car()
        {
            
        }
        public bool HasTrunk { get; set;  }= true;

        public override void DriveHornSoundAbstract()
        {
            Console.WriteLine("beep!");
        }




    }
}
