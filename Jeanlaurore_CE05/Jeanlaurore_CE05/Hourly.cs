using System;
namespace Jeanlaurore_CE05
{
    public class Hourly: Employee
    {
        private decimal _payPerHour;
        private decimal _hoursPerWeek;

        public Hourly(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address)
        {
            //Name = name;
            //Address = address;
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;
        }

        public override decimal CalculatePay()
        {
            return _payPerHour * _hoursPerWeek * 52;
        }

        public override void Terminate()
        {
            Console.WriteLine("Really that's fine!");
        }
    }
}
