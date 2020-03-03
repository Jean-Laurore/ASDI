using System;
namespace Week2_Day1
{
    public class Eagle : Bird
    {



        public Eagle(string name):base(name)
        {
            Console.WriteLine("Eagle created!");
        }

        public override void Fly()
        {
            Console.WriteLine("Eagle fly high");
            //base.Fly();
        }

        public override void Attack()
        {
            Console.WriteLine("");
        }
    }
}
