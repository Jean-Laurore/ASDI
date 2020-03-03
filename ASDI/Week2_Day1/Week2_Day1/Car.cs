using System;
namespace Week2_Day1
{
    public class Car: Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int MPG { get; set; }



        public Car(string line)
        {
            Console.WriteLine("Car created!");
            string[] data = line.Split(',');
            Make = data[1];
            Model = data[2];
            Price = int.Parse(data[3]);
            MPG = int.Parse(data[4]);
        }

        // Second contrustor
        // overloaded cons. different params
        public Car(string make, string model, int price, int mpg)
        {
            Make = make;
            Model = model;
            Price = price;
            MPG = mpg;
        }

    }
}
