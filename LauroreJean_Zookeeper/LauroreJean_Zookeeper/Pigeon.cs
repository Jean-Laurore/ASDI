using System;
using System.Collections.Generic;

namespace LauroreJean_Zookeeper
{
    public class Pigeon : Animal, ITrainable
    {
        public string Signal { get; set; }
        public string Behavior { get; set; }
        public Pigeon(string signal, string behavior, string species, int foodConsumes, string treat):base(species, foodConsumes, treat)
        {
            Behaviors = new Dictionary<string, string>();
            Signal = signal;
            Behavior = behavior;
        }

        
        public Dictionary<string, string> Behaviors { get; set; }

        public string Train(string signal, string behavior)
        {
            Signal = signal;
            
            return "The pigeon learned to fly when whistleling";
        }

        public string Perform(string signal)
        {
            
            return "The pigeon learned to fly when whistleling";
        }


        public override string MakeNoise()
        {
            return "coo roo-c'too-coo sound comes from the pigeon";
        }

        public override string Eat()
        {
            return "The pigeon ate a corn";
        }
    }
}
