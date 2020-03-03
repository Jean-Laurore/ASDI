using System;
using System.Collections.Generic;


// Create a Teacher class that inherits from Person
// Teacher must have the following property
// A dictionary for the address. Have city, state, and zip be the keys of the dictionary

namespace JeanLaurore_CE04
{
    public class Teacher:Person
    {
        public Dictionary<string, string> _myAddress { get; set; }

        

        // Adding the key to the dictionary
        public Teacher(string name, int age):base(name, age)
        {
            _myAddress = new Dictionary<string, string>();
        }

        
    }
}
