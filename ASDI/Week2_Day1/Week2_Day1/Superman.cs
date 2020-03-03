using System;
namespace Week2_Day1
{
    public class Superman:SuperHero
    {
        public string Glasses { get; set; } = "Nerdy";

        public Superman()
        {
            Console.WriteLine("Superman created!");
        }

        public override string PerformPower()
        {
            Console.WriteLine(base.Sleep());
            return "Laser vision activated";
        }

        public override string Sleep()
        {
            return "Sleep standing up" + base.Sleep();
            //return base.Sleep();
        }
    }
}
