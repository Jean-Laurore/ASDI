using System;
namespace LauroreJean_Zookeeper
{
    public class Opossum : Animal
    {
        public Opossum(string species, int foodConsumes, string treat) : base(species, foodConsumes, treat)
        {
        }

        public override string MakeNoise()
        {
            return "hissing sound comes from the opossum.";
        }

        public override string Eat()
        {
            return "The opossum ate a worm.";
        }
    }
}
