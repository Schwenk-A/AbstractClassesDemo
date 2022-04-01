using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Vehicle
{
    internal class Motorcycle : Vehicles
    {

        public Motorcycle()
        {

        }
        public bool HasSideCart { get; set; }= false;


        public override void DriveHornSoundAbstract()
        {
            Console.WriteLine("AWOOOGA");
        }
        public override void DriveCarSoundVirtual()
        {
            Console.WriteLine("grummble");
        }
    }
}
