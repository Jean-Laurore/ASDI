using System;
namespace Week2_Day1
{
    public class Duck: Bird
    {
        // Properties
        public string Movie { get; set; }
        public string Pond { get; set; }

        public Duck(string name, string movie):base(name)
        {
            Console.WriteLine("Duck Created!");
            Movie = movie;
        }

        public override void Attack()
        {
            Console.WriteLine("Quack quack! Your dead.");
        }
    }
}
