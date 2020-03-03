using System;
using System.Collections.Generic;

namespace Day2
{
    public class Day2_CoolCars
    {
        //Member Fields
        private Menu _myMenu;
        private Dictionary<int,Car> _carMax; // reference by vin number


        //Constructor
        public Day2_CoolCars()
        {
            _myMenu = new Menu("Create", "Display Cars", "Exit");
            _myMenu.Title = "Car Warz!";
            _myMenu.Display();

            _carMax = new Dictionary<int, Car>();

            Selection();
        }

        private void Selection()
        {
            //Console.WriteLine("Select a choice: ");
            int choice = Validation.ValidateInt("Make a Selection: ");
            switch (choice)
            {
                case 1:
                    CreateCar();
                    break;

                case 2:
                    DisplayCar();
                    break;

                default:
                    break;
            }
        }

        private void DisplayCar()
        {
            Console.Clear();
            Console.WriteLine("CarMax inventory\n");

            Console.WriteLine($"{"Vin Num",-10} {"Make",-8}Model");
            foreach (KeyValuePair<int, Car> kvp in _carMax)
            {
                Console.WriteLine($"{kvp.Value.vin, -10} {kvp.Value.make, -8} {kvp.Value.model}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void CreateCar()
        {
            Console.Clear();
            Car myCar = new Car();

            //Updates car object 
            myCar.make = Validation.ValidateString("Enter a make: ");
            myCar.model = Validation.ValidateString("Enter a model: ");
            myCar.vin = Validation.ValidateInt("Enter a vin: ");

            // Adding to carmax dictionary
            _carMax.Add(myCar.vin, myCar);

            Console.WriteLine($"New car added! {myCar.make} {myCar.model}");

            Console.WriteLine("\nPress any key to continue...");

            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }
    }
}
