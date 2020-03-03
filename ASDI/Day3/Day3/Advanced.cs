using System;
using System.Collections.Generic;

namespace Day3
{
    public class Advanced
    {
        private Dictionary<string, List<Student>> _school;

        public Advanced()
        {
            //Instantiate
            _school = new Dictionary<string, List<Student>>();

            _school.Add("SDI", new List<Student>());
            _school.Add("ASD", new List<Student>());

            Student student1 = new Student("Bob", 1234);
            Student student2 = new Student("Chuck", 12345);
            Student student3 = new Student("Charlie", 12346);

            _school["SDI"].Add(student1);
            _school["SDI"].Add(student2);
            _school["ASD"].Add(student3);

            DisplayAllStudent();
            RemoveStudent();
            DisplayAllStudent();
        }
        private void DisplayAllStudent()
        {
            // Console.Clear();
            int counter = 0;

            foreach (KeyValuePair<string, List<Student>> kvp in _school)
            {
                Console.WriteLine(kvp.Key);

                foreach (Student student in kvp.Value)
                {
                    counter++;
                    Console.WriteLine($"{counter}: {student.name}");
                }
            }
        }

        private void RemoveStudent()
        {
            //_school["SDI"].RemoveAt(1);
            DisplayAllStudent();
            string course = Validation.ValidateString("Enter a course: ");
            int deletedStudent = Validation.ValidateInt("Enter student: ");
            _school[course].RemoveAt(deletedStudent -1);
        }
    }
}
