using System;
using System.Collections.Generic;

namespace LauroreJean_Zookeeper
{
    public class Parrots : Animal, ITrainable
    {
        public string Signal { get; set; }
        public string Behavior { get; set; }
        public Parrots(string species, int foodConsumes, string treat) :base(species, foodConsumes, treat)
        {

        }

        public Dictionary<string, string> Behaviors { get; set; }

        public string Train(string signal, string behavior)
        {
            Signal = signal;

            return "The parrot learned to fly when whistleling.";
        }

        public string Perform(string signal)
        {

            return "The parrot learned to fly when whistleling.";
        }


        public override string MakeNoise()
        {
            return "squawks sound comes from the parrot.";
        }

        public override string Eat()
        {
            return "The parrot ate a piece a bread.";
        }
    }
}
