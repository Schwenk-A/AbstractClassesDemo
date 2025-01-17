﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleUI.Vehicle;
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
             * Create an abstract class called Vehicles //DONE
             * The vehicle class shall have three string properties Year, Make, and Model //DONE
             * Set the defaults to something generic in the Vehicle class //DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation //DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. //DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle //DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle //DONE
             * Provide the implementations for the abstract methods //DONE
             * Only in the Motorcycle class will you override the virtual drive method //DONE
            */

            // Create a list of Vehicle called vehicles //DONE
            List<Vehicles> vehicleList = new List<Vehicles>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car mustangCar = new Car();
            Motorcycle harleyMotorcycle = new Motorcycle();
            Vehicles vehicleOne = new Car();
            Vehicles vehicleTwo = new Motorcycle();


            //not setting up the mustang has trunk because it is an already set value. 
            //_________________________________________________________________________________________________________________
            mustangCar.Make = "Ford";
            mustangCar.Model = "Mustaaaaaaang";
            mustangCar.Year = 1965; 
            //_________________________________________________________________________________________________________________
            harleyMotorcycle.Make = "harley";
            harleyMotorcycle.Model = "Sportser";
            harleyMotorcycle.Year = 2022 ;
            //_________________________________________________________________________________________________________________
            vehicleOne.Make = "Chevy";
            vehicleOne.Model = "Colorodo";
            vehicleOne.Year = 2022;
            //_________________________________________________________________________________________________________________
            vehicleTwo.Make = "Suzuki";
            vehicleTwo.Model = "Satria";
            vehicleTwo.Year = 2020;
            //_________________________________________________________________________________________________________________

            vehicleList.AddRange(new Vehicles[] { vehicleOne, vehicleTwo, mustangCar, harleyMotorcycle });


            vehicleList.ForEach(v =>
            {
                Console.WriteLine($"This vehicle is a {v.Make}{v.Year}{v.Model}");
                v.DriveCarSoundVirtual();
                v.DriveHornSoundAbstract();
            });



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
