using System;
namespace Jeanlaurore_CE05
{
    public class Manager : Salaried
    {
        private decimal _bonus;
        private decimal _salary;

        public Manager(string name, string address, decimal salary, decimal bonus):base(name, address, salary)
        {
            //Name = name;
            //Address = address;
            _salary = salary;
            _bonus = bonus;
            
        }

        public override decimal CalculatePay()
        {
            return _salary + _bonus;
        }

        public override void Terminate()
        {
            Console.WriteLine("You can't fire me I'm the boss!");
        }
    }
}
