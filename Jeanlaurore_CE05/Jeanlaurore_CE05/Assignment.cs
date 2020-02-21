using System;
using System.Collections.Generic;
using System.Linq;

namespace Jeanlaurore_CE05
{
    public class Assignment
    {
        private Menu _myMenu;

        private List<Employee> _employee = new List<Employee>();

        public Assignment()
        {
            _myMenu = new Menu("Add Employee", "Remove Employee", "Display Payroll", "Exit");
            _myMenu.Title = "Course Tracker";
            _myMenu.Display();
            Selection();
        }

        private void Selection()
        {
            int choice = Validation.ValidateInt("\nMake a selection: ");
            if (choice < 1 || choice > 4)
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
                        Exit();
                        break;
                    default:
                        break;
                }
            }
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
            _myMenu.Title = "Employee";
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
            decimal PayPerHour = Validation.ValidateDecimal("\nPlease enter employee hourly pay? ");
            decimal HoursPerWeek = Validation.ValidateDecimal("\nPlease enter employee hours work per weeks? ");

            FullTime fullTime = new FullTime(Name.ToUpper(), Address.ToUpper(), PayPerHour, HoursPerWeek);

            _employee.Add(fullTime);

            //f.CalculatePay();

            Console.WriteLine("\nFull Time employee created.");

            //_employee.Add(f.Name);
            //_employee.Add(f.Address.);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
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

            string Name = Validation.ValidateString("\nPlease enter employee name: ");
            string Address = Validation.ValidateString("\nPlease enter employee address: ");
            decimal PayPerHour = Validation.ValidateDecimal("\nPlease enter employee hourly pay? ");
            decimal HoursPerWeek = Validation.ValidateDecimal("\nPlease enter employee hours work per weeks? ");

            
            Manager manager = new Manager(Name.ToUpper(), Address.ToUpper(), PayPerHour, HoursPerWeek);

            _employee.Add(manager);

            Console.WriteLine("\nSalary employee created.");


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection2();
        }

        public void MainMenu()
        {
            _myMenu = new Menu("Add Employee", "Remove Employee", "Display Payroll", "Exit");
            _myMenu.Title = "Course Tracker";
            _myMenu.Display();
            Selection();
        }


        
        public void RemoveEmployee()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove Employee:");
            Console.WriteLine("==============");
            Console.WriteLine("==============");
            Console.ForegroundColor = ConsoleColor.Gray;

            int counter = 0;
            Console.WriteLine($"{"  "} {"Name",-10} {"Address",-20} {"Yearly Income"}");

            foreach (Employee employee in _employee)
            {
                counter++;
                Console.WriteLine($"{counter}. {employee.Name.ToUpper(),-10} {employee.Address.ToUpper(),-20} {employee.CalculatePay().ToString("C")}");
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

        public void Exit()
        {
            Console.WriteLine("\nThanks for using my Employee Tracker. GoodBye!");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

}
