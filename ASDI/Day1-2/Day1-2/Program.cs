using System;
using System.Collections.Generic;

namespace Day1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1_2 day1 = new Day1_2();
        }
    }

    class Engine
    {
        public int cylinder;
        public int mpg;

        public Engine()
        {
            Console.WriteLine("Engine Created");
        }
    }

    class Car
    {
        //Fields
        public string make;
        public string model;
        public int year;
        public Engine engine;

        // Constructor
        public Car()
        {
            Console.WriteLine("Car Created");
        }
    }

    class Day1_2
    {
        private string name = "Jean";
        private int age = 18;

        private List<Car> _garage;

        public Day1_2()
        {
            Console.WriteLine("Day Started");
            Car jCar = new Car();
            jCar.make = "Chevy";
            jCar.model = "Camara";
            jCar.year = 2016;

            jCar.engine = new Engine();
            jCar.engine.cylinder = 6;
            jCar.engine.mpg = 15;

            Car Kcar = new Car();
            Kcar.make = "Honda";
            Kcar.model = "Accord";
            Kcar.engine = new Engine();
            Kcar.engine.cylinder = 8;
            Kcar.engine.mpg = 30;

            _garage = new List<Car>();

            _garage.Add(jCar);
            _garage.Add(Kcar);

            DisplayCars();
        }

        public void DisplayCars()
        {
            Console.Clear();
            Console.WriteLine($"{"Make", -7} {"Model", -7} {"MPG", -7}");
            foreach (Car car in _garage)
            {
                Console.WriteLine($"{car.make, -7} {car.model, -7} {car.engine.mpg, -7}");
            }
        }

    }
}
