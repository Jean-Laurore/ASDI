using System;
using System.Collections.Generic;

namespace Week2_Day1
{
    public class Day9_Interfaces
    {
        private List<Tools> _tools = new List<Tools>();
        public Day9_Interfaces()
        {
            Tools tools1 = new Tools("Hamer");
            Tools tools2 = new Tools("Axe");
            Tools tools3 = new Tools("Drill");

            _tools.Add(tools1);
            _tools.Add(tools2);
            _tools.Add(tools3);

            Console.WriteLine("Adam".CompareTo("Dave"));
            _tools.Sort();

            foreach (Tools item in _tools)
            {
                Console.WriteLine(item.ToolType);
            }
        }
    }

    public class Tools : IComparable<Tools>
    {
        public string ToolType { get; set; }
        public Tools(string type)
        {
            ToolType = type;
        }

    public int CompareTo(Tools other)
    {
            return ToolType.CompareTo(other.ToolType);
    }
    }

}