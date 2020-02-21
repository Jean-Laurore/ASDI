using System;
using System.Collections.Generic;

namespace Jeanlaurore_CE05
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        
        public Employee(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual decimal CalculatePay()
        {
            return 0;
        }

        abstract public void Terminate();
    }
}
