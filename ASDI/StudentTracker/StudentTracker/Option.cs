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
            _school = new Dictionary<string, List<Student>>();
            _school.Add("WEB".ToUpper(), new List<Student>());
            _school.Add("MOBILE".ToUpper(), new List<Student>());

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

           

            string name = Validation.ValidateString("\nEnter name: ");
            //Console.WriteLine("WEB");
            //Console.WriteLine("MOBILE");
            //string degree = Validation.ValidateString("\nEnter degree: ");

            Student s = new Student();

            s.Name = name.ToUpper();
            //s.Degree = degree.ToUpper();

            //if (degree == "WEB".ToUpper())
            //{
            //    _school["WEB".ToUpper()].Add(s);
            //    Console.WriteLine("Press any key to continue...");
            //    Console.ReadKey();
            //    _myMenu.Display();
            //}
            //else if (degree == "MOBILE".ToUpper())
            //{
            //    _school["MOBILE".ToUpper()].Add(s);
            //    Console.WriteLine("Press any key to continue...");
            //    Console.ReadKey();
            //    _myMenu.Display();
            //}
            //else
            //{
            //    //AddStudent();
            //}


            int counter = 1;
            Console.WriteLine("\nDegree: ");
            string[] temp = new string[_school.Count];
            foreach (string key in _school.Keys)
            {
                temp[counter - 1] = key;
                Console.WriteLine($"{counter}. {key}");
                counter++;
            }
            int degreeChoice = Validation.ValidateInt("Choose a degree to add your name to: ");
            _school[temp[degreeChoice - 1]].Add(s);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();

        }

        public int[] grades;
        public double amount;
        public double avg;
        public int random;
        public int random1;
        public int random2;

        public void GenerateGrade()
        {
            Random myRandom = new Random();
            random = myRandom.Next(0, 80);
            random1 = myRandom.Next(0, 80);
            random2 = myRandom.Next(0, 80);
            amount = (random + random1 + random2);
            avg = amount / 3;
            //Console.WriteLine($"\n{"  "} {"Grades",-15} {"Average",-18}");
            Console.WriteLine($"{random} {random1} {random2}{"", -10}{avg.ToString("0")}");

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
            Console.WriteLine($"{"  "} {"Name",-15} {"Degree",-10} {"Grades",-15} {"Average"}");
            foreach (KeyValuePair<string, List<Student>> kvp in _school)
            {
                counter++;

                Console.Write($"\n{counter}. {kvp.Key.ToUpper(),-15}");
                foreach (Student student in kvp.Value)
                {
                    Console.Write($"  {student.Name.ToUpper(),-8} "); GenerateGrade();
                }
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



            int counter = 0;
            Console.WriteLine($"{"  "} {"Name",-15} {"Degree",-10} {"Grades",-15} {"Average"}");
            foreach (KeyValuePair<string, List<Student>> kvp in _school)
            {
                counter++;
                if (kvp.Key == "MOBILE")
                {
                    Console.Write($"{counter}. {kvp.Key.ToUpper(),-15}");
                    //Console.Write($"  {student.Degree.ToUpper(),-8} "); GenerateGrade();
                }
                //Console.Write($"\n{counter}. {kvp.Key.ToUpper(),-15}");
                foreach (Student student in kvp.Value)
                {
                    Console.Write($"  {student.Degree.ToUpper(),-8} "); GenerateGrade();
                }
            }



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
            //Student myStudent = new Student();


            int counter = 0;
            Console.WriteLine($"{"  "} {"Name",-15} {"Degree",-10} {"Grades",-15} {"Average"}");
            foreach (KeyValuePair<string, List<Student>> kvp in _school)
            {
                counter++;
                if (kvp.Key == "WEB")
                {
                    Console.WriteLine($"{counter}. {kvp.Key}");
                }
                else if (kvp.Key == "MOBILE")
                {
                    Console.WriteLine($"{counter}. {kvp.Key.ToUpper()}");
                }
                //Console.Write($"\n{counter}. {kvp.Key.ToUpper(), -15}");
                foreach (Student student in kvp.Value)
                {
                    Console.Write($"  {student.Name.ToUpper(),-8} "); GenerateGrade();
                }
            }




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
            //Student myStudent = new Student();

                    
            //int counter = 0;
            //Console.WriteLine($"{"  "} {"Name",-15} {"Degree",-10}");
            //foreach (KeyValuePair<string, string> kvp in _studentDegree)
            //{

            //    counter++;
            //    Console.WriteLine($"{counter}. {kvp.Key,-15} {kvp.Value,-10}");
            //    myStudent.GenerateGrade();
            //}

            string studentName = Validation.ValidateString("Enter student name to be remove from the roster: ");
            _school.Remove(studentName.ToUpper());

            //Console.WriteLine($"{myStudent.name} has been successful remove");

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
