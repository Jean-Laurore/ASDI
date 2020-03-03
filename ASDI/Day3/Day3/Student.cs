using System;
namespace Day3
{
    public class Student
    {
        public string name;
        public int id;

        public Student(string n, int i)
        {
            name = n;
            id = i;
            Console.WriteLine("Student Created!");
        }
    }
}
