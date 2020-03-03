using System;
namespace Week2_Day1
{
    public class Boat: Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int EngineCount { get; set; }



        public Boat(string line)
        {
            Console.WriteLine("Boat Created");
            string[] data = line.Split(',');
            Make = data[1];
            Model = data[2];
            EngineCount = int.Parse(data[3]);
        }
    }
}
