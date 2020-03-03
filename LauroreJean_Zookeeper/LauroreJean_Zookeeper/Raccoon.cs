using System;
namespace LauroreJean_Zookeeper
{
    public class Raccoon : Animal
    {
        public Raccoon(string species, int foodConsumes, string treat):base(species, foodConsumes, treat)
        {
        }

        public override string MakeNoise()
        {
            return "growling sound comes from the raccoon.";
        }

        public override string Eat()
        {
            return "The raccoon ate a piece a bread out the trash.";
        }
    }
}
