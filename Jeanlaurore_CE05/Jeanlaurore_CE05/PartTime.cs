using System;
namespace Jeanlaurore_CE05
{
    public class PartTime : Hourly
    {
        private decimal _payPerHour;
        private decimal _hoursPerWeek;

        public PartTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour, hoursPerWeek)
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
            Console.WriteLine("God Bless You!");
        }
    }
}
