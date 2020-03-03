using System;
namespace JeanLaurore_CE04
{
    public class Student:Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade):base(name, age)
        {
            Grade = grade;
        }

        
    }
}
