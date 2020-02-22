using System;
using System.Collections.Generic;

namespace Jeanlaurore_CE05
{
    public class FullTime : Hourly
    {
        private decimal _payPerHour;
        private decimal _hoursPerWeek = 40;

        public FullTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour, hoursPerWeek)
        {
            //Name = name;
           // Address = address;
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;
            //CalculatePay();
        }

        public override decimal CalculatePay()
        {
            decimal total = _payPerHour * _hoursPerWeek * 52;
            return total;
        }

        public override void Terminate()
        {
            Console.WriteLine("Really that's fine!");
        }
    }
}
