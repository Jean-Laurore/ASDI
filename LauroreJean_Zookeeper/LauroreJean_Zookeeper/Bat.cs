using System;
namespace LauroreJean_Zookeeper
{
    public class Bat : Animal
    {
        public Bat(string species, int foodConsumes, string treat) : base(species, foodConsumes, treat)
        {
        }

        public override string MakeNoise()
        {
            return "clicks sound comes from the parrot.";
        }

        public override string Eat()
        {
            return "The bat ate a insect.";
        }
    }
}
