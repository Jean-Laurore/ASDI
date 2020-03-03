using System;
namespace Week2_Day1
{
    public class Interfaces
    {
        public Interfaces()
        {

        }

        // Bike implement IDrivalble interface
        public class Bike:IDrivable
        {
            public Bike()
            {
                Console.WriteLine("Bike created!");
            }
            public void Accelerate()
            {

            }

            public void Brake()
            {

            }
             
            public void Steer(string direction)
            {

            }
        }

        interface IDrivable
        {
            void Accelerate();
            void Brake();
            void Steer(string direction);
        }
    }
}
