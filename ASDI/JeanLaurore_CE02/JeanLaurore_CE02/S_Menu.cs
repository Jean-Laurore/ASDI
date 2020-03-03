using System;
using System.Linq;
using System.Collections.Generic;

namespace JeanLaurore_CE02
{
    public class S_Menu
    {
        private List<string> _items;

        public string course = "";
        public string title = "Main Menu";

        public S_Menu(params string[] items)
        {
            _items = items.ToList<string>();
        }

        public void Display()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ADVANCED SCALABLE DATA INFRASTRUCTURES");
            Console.WriteLine("======================================================");
            Console.WriteLine("======================================================");
            Console.WriteLine(course);
            Console.WriteLine("\n" + title);
            Console.WriteLine("\nPlease enter the number you want to run...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("********************************************");
            for (int i = 0; i < _items.Count; i++)
            {
                // Interpolated string 
                Console.WriteLine($"{i + 1}: {_items[i]}");
            }
        }
    }
}
