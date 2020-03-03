using System;
using System.Collections.Generic;

namespace Week2_Day1
{
    public class Day10_Review
    {

        public Day10_Review()
        {
            // list dictionary
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

            //Adding to the list
            groups.Add("Cool Kids", new List<string>());
            groups.Add("Super Cool Kids", new List<string>());

            //Adding values to keys or the super cool kids group
            groups["Super Cool Kids"].Add("Tim");
            groups["Super Cool Kids"].Add("Ed");
            groups["Cool Kids"].Add("Bob");

            //removing ed form the group
            groups["Super Cool Kids"].RemoveAt(1);


            foreach (KeyValuePair<string, List<string>> kvp in groups)// looping to the groups first
            {

                foreach (string student in kvp.Value)
                {
                    Console.WriteLine($"{student}");
                }
            }


            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(12345, "Bob");
            students.Add(13245, "Tim");
            students.Add(32145, "Scott");
            students.Remove(13245);

            foreach (KeyValuePair<int, string> kvp in students)
            {
                Console.WriteLine($"{kvp.Value}");
            }

            if (students.ContainsKey(32145))// Checking to see of the key exist.
            {
                //just to get the key without an loop
                Console.WriteLine(students[32145]);

            }

            Chair superChair = new Chair();
            superChair.CP.Power = false;
        }
    }

    public class Chair
    {
        public decimal Price { get; set; }
        public ControlPanel CP { get; set; }

        public Chair()
        {
            //Instantiate a control panel
            CP = new ControlPanel();
        }
    }

    public class ControlPanel
    {
        public Boolean Power { get; set; } = true;

        public ControlPanel()
        {

        }
    }

    public abstract class Drink
    {
        public int Calaries { get; set; }

        public Drink()
        {

        }

        public abstract string Taste(); //Have no code. Required to be overriden


        public virtual string Smell() // Have code
        {
            return "Smells normal";
        }
    }

    public class Water: Drink
    {
        public Water()
        {

        }

        public override string Taste()
        {
            return "Taste like water";
        }
    }
}
