using System;
namespace Week2_Day1
{
    public class Penguin : Bird
    {


        public Penguin(string name):base(name)
        {
            Console.WriteLine("Penguin created!");
        }

        //POLY
        public override void Fly()
        {
            Console.WriteLine("I swim instead!");
        }

        public override void Attack()
        {
            Console.WriteLine("Sniff me! You dead!");
        }
    }
}
