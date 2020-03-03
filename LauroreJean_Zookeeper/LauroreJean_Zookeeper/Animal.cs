using System;
namespace LauroreJean_Zookeeper
{
    public abstract class Animal
    {
        public string Species { get; set; }

        private int _foodConsumed;
        private string _treat;

        public Animal(string species, int foodConsumed, string treat)
        {
            Species = species;
            _foodConsumed = foodConsumed;
            _treat = treat;
        }

        public virtual string Eat()
        {
            return "The animal ate corn";
        }

        public virtual string MakeNoise()
        {
            return "Quak Quak!";
        }

        public void Poop()
        {
            Console.WriteLine();
        }
    }
}
