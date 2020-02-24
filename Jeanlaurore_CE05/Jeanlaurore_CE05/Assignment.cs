using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Jeanlaurore_CE05
{
    public class Assignment
    {
        private string _directory = @"../../../output/";
        private string _fileName = "employees.txt";
        private string _jsonFile = "data.json";
        private Menu _myMenu;

        private List<Employee> _employee = new List<Employee>();

        public Assignment()
        {
            CreatingFile();
            Load();
            _myMenu = new Menu("Add Employee", "Remove Employee", "Display Payroll", "Save JSON", "Exit");
            _myMenu.Title = "Employee Tracker";
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
                        AddEmployee();
                        break;
                    case 2:
                        RemoveEmployee();
                        break;
                    case 3:
                        DisplayPayrol();
                        break;
                    case 4:
                        SaveToJSON();
                        break;
                    case 5:
                        Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        public void CreatingFile()
        {
            Directory.CreateDirectory(_directory);

            if (!File.Exists(_directory + _fileName))
            {
                File.Create(_directory + _fileName).Dispose();
                Console.WriteLine("File Created!");

            }
            else
            {
                Console.WriteLine("File exist");
            }
            //SaveToJSON();
        }

        public void AddEmployee()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add Employee:");
            Console.WriteLine("=============");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Gray;

            
            Selection2();


        }
           private void Selection2()
            {
            _myMenu = new Menu("Full Time", "Part Time", "Salary", "Manager", "Main Menu");
            _myMenu.Title = "Employees";
            _myMenu.Display();

            int choice = Validation.ValidateInt("\nMake a selection: ");
                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid Entry. Try again!");
                    Selection2();
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            FullTime();
                            break;
                        case 2:
                            PartTime();
                            break;
                        case 3:
                            Salaried();
                            break;
                        case 4:
                            Manager();
                            break;
                        case 5:
                            MainMenu();
                        break;
                    default:
                            break;
                    }
                }
            }

        public void FullTime()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Full Time:");
            Console.WriteLine("==============");
            Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Gray;

            string Name = Validation.ValidateString("\nPlease enter employee name: ");            
            string Address = Validation.ValidateString("\nPlease enter employee address: ");
            decimal HoursPerWeek = 40;
            decimal PayPerHour = Validation.ValidateDecimal("\nPlease enter employee pay per hour? ");

            FullTime fullTime = new FullTime(Name.ToUpper(), Address.ToUpper(), PayPerHour, HoursPerWeek);

            _employee.Add(fullTime);


            Console.WriteLine("\nFull Time employee created.");

            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        private void Load()
        {
            using (StreamReader sr = new StreamReader(_directory + _fileName))
            {
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("Kalen"))
                    {
                        FullTime f = new FullTime("Kalen".ToUpper(), "2235 River".ToUpper(), 18, 40);
                        _employee.Add(f);
                    }
                    else if (line.Contains("Marcus"))
                    {
                        FullTime f1 = new FullTime("Marcus".ToUpper(), "2235 Land".ToUpper(), 27, 40);
                        _employee.Add(f1);
                    }
                    else if (line.Contains("Kevin"))
                    {
                        FullTime f2 = new FullTime("Kevin".ToUpper(), "2235 Beach".ToUpper(), 27, 40);
                        _employee.Add(f2);
                    }
                }
            }
        }

        /// <summary>
        /// Save Json need to employee file and return to menu
        /// </summary>
        private void SaveToJSON()
        {

            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Green;
            LoadingBar();
            Console.ForegroundColor = ConsoleColor.Gray;
            
            //CreatingFile();
            using (StreamWriter sw = new StreamWriter(_directory + _jsonFile))
            {
                sw.WriteLine("[");
                
                int counter = 0;
                foreach (Employee employee in _employee)
                {
                    sw.WriteLine("{");
                    sw.WriteLine($"\"Name\":\"{employee.Name.ToUpper()}\",");
                    sw.WriteLine($"\"Address\":\"{employee.Address.ToUpper()}\",");
                    sw.WriteLine($"\"Yearly\":{employee.CalculatePay()}");
                    if (counter < _employee.Count -1)
                    {
                        sw.WriteLine("},");
                    }
                    else
                    {
                        sw.WriteLine("}");
                    }
                    counter++;
                }
                sw.WriteLine("]");
            }

            Console.WriteLine("\nSuccessful!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void PartTime()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Part Time:");
            Console.WriteLine("==========");
            Console.WriteLine("==========");
            Console.ForegroundColor = ConsoleColor.Gray;

            string Name = Validation.ValidateString("\nPlease enter employee name: ");
            string Address = Validation.ValidateString("\nPlease enter employee address: ");
            decimal PayPerHour = Validation.ValidateDecimal("\nPlease enter employee hourly pay? ");
            decimal HoursPerWeek = Validation.ValidateDecimal("\nPlease enter employee hours work per weeks? ");

            PartTime partTime = new PartTime(Name.ToUpper(), Address.ToUpper(), PayPerHour, HoursPerWeek);

            _employee.Add(partTime);

            Console.WriteLine("\nPart Time employee created.");


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        public void Salaried()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Salary:");
            Console.WriteLine("=======");
            Console.WriteLine("=======");
            Console.ForegroundColor = ConsoleColor.Gray;

            string Name = Validation.ValidateString("\nPlease enter employee name: ");
            string Address = Validation.ValidateString("\nPlease enter employee address: ");
            decimal Salary = Validation.ValidateDecimal("\nPlease enter employee salary? ");

            
            Salaried salary = new Salaried(Name.ToUpper(), Address.ToUpper(), Salary);

            _employee.Add(salary);

            Console.WriteLine("\nSalary employee created.");


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        public void Manager()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Manager:");
            Console.WriteLine("========");
            Console.WriteLine("========");
            Console.ForegroundColor = ConsoleColor.Gray;

            string Name = Validation.ValidateString("\nPlease enter manager name: ");
            string Address = Validation.ValidateString("\nPlease enter manager address: ");
            decimal Salary = Validation.ValidateDecimal("\nPlease enter manager salary? ");
            decimal Bonus = Validation.ValidateDecimal("\nPlease enter manager bonus? ");

            
            Manager manager = new Manager(Name.ToUpper(), Address.ToUpper(), Salary, Bonus);

            _employee.Add(manager);

            Console.WriteLine("\nSalary employee created.");


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        public void MainMenu()
        {
            _myMenu = new Menu("Add Employee", "Remove Employee", "Display Payroll", "Save JSON", "Exit");
            _myMenu.Title = "Employee Tracker";
            _myMenu.Display();
            Selection();
        }


        
        public void RemoveEmployee()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove Employee:");
            Console.WriteLine("================");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.Gray;

            int counter = 0;
            Console.WriteLine($"{"  "} {"Name",-15} {"Address",-25} {"Yearly Income"}");

            foreach (Employee employee in _employee)
            {
                counter++;
                Console.WriteLine($"{counter}. {employee.Name.ToUpper(),-15} {employee.Address.ToUpper(),-25} {employee.CalculatePay().ToString("C")}");
            }

            string name = Validation.ValidateString("\nPlease enter employee name to remove: ");

            foreach (Employee employee in _employee)
            {
                if (employee.Name.Contains(name.ToUpper()))
                {
                    _employee.Remove(employee);
                    employee.Terminate();
                    break;
                }
            }



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void DisplayPayrol()
        {
            
            Console.Clear();
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display Payroll:");
            Console.WriteLine("================");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.Gray;

            int counter = 0;
            Console.WriteLine($"{"  "} {"Name", -10} {"Address", -20} {"Yearly Income"}");

            foreach (Employee employee in _employee)
            {
                counter++;
                Console.WriteLine($"{counter}. {employee.Name.ToUpper(), -10} {employee.Address.ToUpper(), -20} {employee.CalculatePay().ToString("C")}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void LoadingBar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i < 101; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("");
                }
                Console.Write($"SAVING... {i}%");
                Console.SetCursorPosition(1, 1);
                Thread.Sleep(50);
            }
        }

        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using my Employee Tracker. GoodBye!");
        }
    }

}
