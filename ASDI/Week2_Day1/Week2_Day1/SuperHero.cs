using System;
using System.Collections.Generic;
namespace Week2_Day1
{
    abstract public class SuperHero
    {
        //Public properties
        public string Name { get; set; }
        public List<string> Weaknesses { get; set; } = new List<string>();

        public SuperHero()
        {
            Console.WriteLine("Superhero created!");
        }

        // Actions. Method. Abilities
        abstract public string PerformPower(); //Vague //Have to implemented

        public virtual string Sleep()
        {
            return "I close my eyes";
        }
    }

}
