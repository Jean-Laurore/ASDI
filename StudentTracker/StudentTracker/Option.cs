using System;
using System.Collections.Generic;

namespace StudentTracker
{
    public class Option
    {
        // Fields
        //Calling the menu call and set to private
        private Menu _myMenu;

        private Dictionary<string, List<Student>> _school;

        public Option()
        {
            //Instantiation
            _school = new Dictionary<string, List<Student>>();

            _myMenu = new Menu("Show All Students", "Show Mobile Students", "Show Web Students", "Add Student", "Remove Student", "Exit");
            _myMenu.Title = "Student Tracker";
            _myMenu.Display();

            Selection();
        }

        private void Selection()
        {
            int choice = Validation.ValidateInt("\nMake a selection: ");
            switch (choice)
            {
                case 1:
                    ShowAllStudents();
                    break;
                case 2:
                    ShowMobileStudents();
                    break;
                case 3:
                    ShowWebStudents();
                    break;
                case 4:
                    AddStudent();
                    break;
                case 5:
                    RemoveStudent();
                    break;
                case 6:
                    Exit();
                    break;
                default:
                    break;
            }
        }

        private void AddStudent()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add Student: ");
            Console.WriteLine("============");
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Gray;

            Student myStudent = new Student();

            myStudent.name = Validation.ValidateString("\nPlease enter student name: ");
            _school.Add(myStudent.name, new List<Student>());

            myStudent.degree = Validation.ValidateString("Please enter student degree: ");
            _school.Add(myStudent.degree, new List<Student>());

            Student student1 = new Student();
            _school[myStudent.name].Add(student1);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void ShowAllStudents()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Show All Students: ");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;

            int counter = 0;
            //Console.WriteLine($"{"Name", -10} {"Degree", -10}");
            foreach (KeyValuePair<string, List<Student>> kvp in _school)
            {
                Console.WriteLine($"{kvp.Key}");

                //foreach (Student student in kvp.Value)
                //{
                //    counter++;
                //    Console.WriteLine($"{student.name}");
                //}
            }




            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void ShowMobileStudents()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Show Mobile Students: ");
            Console.WriteLine("=====================");
            Console.WriteLine("=====================");
            Console.ForegroundColor = ConsoleColor.Gray;







            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void ShowWebStudents()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Show Web Students: ");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;







            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        
        private void RemoveStudent()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove Student: ");
            Console.WriteLine("===============");
            Console.WriteLine("===============");
            Console.ForegroundColor = ConsoleColor.Gray;







            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void Exit()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Exit:");
            Console.WriteLine("=====");
            Console.WriteLine("=====");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nThanks for using my student tracker. Farewell!");
        }
    }
}
