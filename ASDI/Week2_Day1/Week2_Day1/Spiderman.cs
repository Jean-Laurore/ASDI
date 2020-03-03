using System;
namespace Week2_Day1
{
    public class Spiderman:SuperHero
    {
        public string WebType { get; set; } = "Silk";
        public Spiderman()
        {
            Console.WriteLine("Spiderman Created!");
        }

        public string SpinWeb()
        {
            return$"I spin my {WebType} web";
        }

        public override string PerformPower()
        {
            return "Spidey Senses activated";
        }
    }
}
