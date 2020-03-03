using System;
namespace Week2_Day1
{
    public abstract class Item
    {
        public decimal Price { get; set; }
        public double ID { get; set; }
        public string Name { get; set; }

        public Item()
        {
            Console.WriteLine("Item created");
        }

        public abstract string Purchase();
       
    }

    public class Fruit : Item
    {
        public string Type { get; set; }

        public Fruit(string line)
        {
            Console.WriteLine("Fruit created!");
            string[] data = line.Split(',');
            Type = data[1];
            Price = int.Parse(data[2]);
            ID = int.Parse(data[3]);
        }

        public override string Purchase()
        {
            return "Item purchased";
        }
        public override string ToString()
        {
            return $"{Type, -12} {Price,-5} {ID}";
        }
    }

    public class Computer : Item
    {
        public string Processor { get; set; }
        public string Brand { get; set; }


        public Computer(string line)
        {
            Console.WriteLine("Computer created!");
            string[] data = line.Split(',');
            Brand = data[1];
            Processor = data[2];
            Price = decimal.Parse(data[3]);
            ID = double.Parse(data[4]);
            Name = "MAC";
        }

        public override string Purchase()
        {
            return "Item purchased with insurance";
        }
        public override string ToString()
        {
            return $"{Processor, -12} {Brand,-8} {Price,-5} {ID}";
        }
    }

    public class TV : Item
    {
        public string Brand { get; set; }


        public TV(string line)
        {
            Console.WriteLine("TV created!");
            string[] data = line.Split(',');
            Brand = data[1];
            Price = decimal.Parse(data[2]);
            ID = double.Parse(data[3]);
            Name = "Tel";
        }

        public override string Purchase()
        {
            return "Item purchased without insurance";
        }
        public override string ToString()
        {
            return $"{"Tel", -12} {Brand, -8} {Price, -5} {ID}";
        }
    }
}
