using System;
using System.Collections.Generic;

namespace LauroreJean_Zookeeper
{
    public class Dog : Animal, ITrainable
    {
        public string Signal { get; set; }
        public string Behavior { get; set; }

        public Dog(string species, int foodConsumes, string treat):base(species, foodConsumes, treat)
        {

        }

        public Dictionary<string, string> Behaviors { get; set; }

        public string Train(string signal, string behavior)
        {
            Signal = signal;

            return "The dog learned to jog when whistleling";
        }

        public string Perform(string signal)
        {

            return "The dog learned to hop when whistleling";
        }


        public override string MakeNoise()
        {
            return "woof woof sound comes from the dog";
        }

        public override string Eat()
        {
            return "The dog ate a bone";
        }
    }
}
