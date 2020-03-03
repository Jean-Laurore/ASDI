using System;
using System.Collections.Generic;

namespace Day2
{
    public class Day2_Demo
    {
        // Member fields
        private List<string> _car;
        private Dictionary<string, string> _carDictionary;

        public Day2_Demo()
        {
            Console.WriteLine("Day 2 Started!");
            _car = new List<string>() { "Toyota", "Camry", "10000" };
            //Console.WriteLine(_car[0]);

            _carDictionary = new Dictionary<string, string>();
            _carDictionary.Add("make", "Toyota");
            _carDictionary.Add("model", "Camry");
            _carDictionary.Add("price", "10000");
            //Console.WriteLine(_carDictionary["make"]);
            //Determine number of key value pairs
            //Console.WriteLine(_carDictionary.Count);
            _carDictionary.Remove("price");
            //Looping thru dictionary
            foreach (KeyValuePair<string, string> item in _carDictionary)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key);
            }
            if (_carDictionary.ContainsKey("mpg"))
            {
                Console.WriteLine(_carDictionary["mpg"]);
            }
            else
            {
                Console.WriteLine("Key does not exit");
            }

        }
    }
}
