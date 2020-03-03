using System;
using System.Collections.Generic;


namespace JeanLaurore_CE04
{
    public class Assignment
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private Menu _myMenu;
        private Course _currentCourse;
        private Teacher _currentCourseTeacher;
        private Student _currentCourseStudent;
        private string _name;
        private int _age;
        private string menuTitle = "";
        private int i = 0;

        //private Dictionary<string, string> _myAddress = new Dictionary<string, string>();


        public Assignment()
        {
            _myMenu = new Menu("Create Course", "Create Teacher", "Add Student", "Display", "Exit");
            _myMenu.Title = "Course Tracker";
            _myMenu.Display();
            Selection();
        }

        private void Selection()
        {
            int choice = Validation.ValidateInt("\nMake a selection: ");
            if (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Selection();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        CreateCourse();
                        break;
                    case 2:
                        CreateTeacher();
                        break;
                    case 3:
                        AddStudent();
                        break;
                    case 4:
                        Display();
                        break;

                    case 5:
                        Exit();
                        break;

                    default:
                        break;
                }

            }
            }
            
        public void CreateCourse()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Create Course:");
            Console.WriteLine("==============");
            Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Gray;


            string cn = Validation.ValidateString("\nEnter course name: ");
            int numStudent = Validation.ValidateInt("\nEnter the number of student: ");
            if (numStudent > 10)
            {
                Console.WriteLine($"{numStudent} students! too many students. Please go for smaller size.");
                Console.ReadKey();
                CreateCourse();
            }
            if (numStudent <= 0)
            {
                Console.WriteLine("Invalid Selection. Try again!");
                Console.ReadKey();
                CreateCourse();
            }
            else
            {
                _currentCourse = new Course(cn, numStudent);
                _currentCourse.Class = new Student[numStudent];
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void CreateTeacher()
        {
                Console.Clear();
                //Setting UI color
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Create Teacher:");
                Console.WriteLine("==============");
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Gray;

            if (_currentCourse == null)
            {
                Console.WriteLine("Please create a course first");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
            AskNameAge();
            _currentCourseTeacher = new Teacher(_name, _age);
            string state = Validation.ValidateString("Name of State: ");
            string city = Validation.ValidateString("Name of city: ");
            string zip = Validation.ValidateString("Zipcode: ");

            while (zip.Length < 5 || zip.Length >= 6)
            {
                Console.WriteLine("That is not a valid zipcode please try again: ");
                zip = Validation.ValidateString("Zipcode: ");

            }
            _currentCourseTeacher._myAddress.Add("state", state);
            _currentCourseTeacher._myAddress.Add("city", city);
            _currentCourseTeacher._myAddress.Add("zip", zip);

            Console.WriteLine("\nTeacher has been created.");

            Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            
        }

        public void AddStudent()
        {
           
                Console.Clear();
                //Setting UI color
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Add Student:");
                Console.WriteLine("==============");
                Console.WriteLine("==============");
                Console.ForegroundColor = ConsoleColor.Gray;
                
            if (_currentCourse == null)
            {
                Console.WriteLine("Please create a course first or... ");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
                
            if (i < _currentCourse.Class.Length)
            {//
                DisplayMenuTitle("Add a Student");
                AskNameAge();
                if (_name == _age.ToString())
                {
                    string validate = Validation.ValidateString($"{_name} is already in the class.");
                }
                Random random = new Random();
                int randomNumber = random.Next(0, 100);
                _currentCourseStudent = new Student(_name, _age, randomNumber);
                _currentCourse.Class[i] = _currentCourseStudent;

                i++;
                if (i < _currentCourse.Class.Length)
                {
                    string validate = Validation.ValidateString($"{i}: {_name} has been added.");
                    AddStudent();
                }
                if (i < _currentCourse.Class.Length)
                {
                    Console.WriteLine($"You need to have {_currentCourse.Class.Length} total students in your class you currently have {i}. \nPlease go back and add more students: ");
                    Console.ReadKey();
                    AddStudent();
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }//


                
            else if (i > _currentCourse.Class.Length)
            {
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }

        }

        public void Display()
        {

            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display:");
            Console.WriteLine("==============");
            Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Gray;

            if (_currentCourse == null || _currentCourse.Class == null || _currentCourse.Class.Length != i)
            {
                Console.WriteLine("Please Create a Course or Teacher Before trying to Display this");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
            else
            {
                Console.WriteLine("\nTeacher");
                Console.WriteLine("********************");
                Console.WriteLine("");
                Console.WriteLine($"Name: {_currentCourseTeacher.Name} \nAge: {_currentCourseTeacher.Age,-10}");
                foreach (KeyValuePair<string, string> kvp in _currentCourseTeacher._myAddress)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value,-10}");
                    //break;
                }

                foreach (Student student in _currentCourse.Class)
                    {
                        Console.WriteLine($"\nCourse Title: {_currentCourse.CourseTitle}");
                        
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("\nStudent");
                        Console.WriteLine("*****************************");
                        Console.WriteLine($"Name: {student.Name} \nAge:{student.Age}");
                        AveragedNumbers();

                    }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();

        }

        public void Exit()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Exit:");
            Console.WriteLine("==============");
            Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.WriteLine("\nThank you, GoodBye!");
            

        }

        private void DisplayMenuTitle(string s)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            menuTitle = s;
            Console.WriteLine(s + "\n----------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void AskNameAge()
        {
            _name = Validation.ValidateString("Enter name: ");
            _age = Validation.ValidateInt($"Enter Age of {_name}: ");
        }

        private void AveragedNumbers()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            int randomNumber1 = random.Next(0, 100);
            int randomNumber2 = random.Next(0, 100);
            decimal sum = (randomNumber + randomNumber1 + randomNumber2);
            decimal average = (sum / 3);
            decimal roundAverage = Math.Round(average, 02);

            Console.WriteLine($"GRADES: {randomNumber1} {randomNumber} {randomNumber2} \nAVERAGE: {roundAverage.ToString("0")}");
        }
    }
}
