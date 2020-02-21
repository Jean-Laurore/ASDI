using System;
namespace Jeanlaurore_CE05
{
    public class Salaried : Employee
    {
        private decimal _salary;

        public Salaried(string name, string address, decimal salary):base(name, address)
        {
            //Name = name;
            //Address = address;
            _salary = salary;
        }

        public override decimal CalculatePay()
        {
            return _salary;
        }

        public override void Terminate()
        {
            Console.WriteLine("WHATEVER!");
        }
    }
}
