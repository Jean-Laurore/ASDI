using System;
namespace Week2_Day1
{
    public class Student
    {
        private string _name;
        private int _id;

        //Properties always Upper Case
        public int Age { get; set; }

        public Student(string n, int i)
        {
            _name = n;
            _id = i;
            Console.WriteLine("Student Created!");
        }

        public int Id
        {
            get { return _id; }
        }

        // Properties expose the fields
        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "Bob")
                {
                    Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine(_name = value);
                }
            }

        }
    }
}