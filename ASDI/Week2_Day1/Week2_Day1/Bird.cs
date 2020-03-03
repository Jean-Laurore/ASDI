using System;
namespace Week2_Day1
{
    public abstract class Bird
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Food { get; set; }

        public Bird(string name)
        {
            Console.WriteLine("Bird Created!");
            Name = name;
        }

        public virtual void Fly()
        {
            Console.WriteLine("Wings go up!");
        }

        //Fight
        //No Implementation
        abstract public void Attack();
    }
}
