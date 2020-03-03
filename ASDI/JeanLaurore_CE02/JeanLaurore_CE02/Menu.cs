using System;
using System.Linq;
using System.Collections.Generic;
using DVP1;


// Name: Jean Laurore 
// Date: 2020 - 03
// CE Name: Coding Exercise - Menu
// Synopsis: This class will be use to display the menu selection.

namespace JeanLaurore_CE02
{
    public class Menu
    {
        //Fields
        private S_Menu _myMenu;

        public Menu()
        {
            _myMenu = new S_Menu("Create Customer", "Create Account", "Set Account Balance", "Display Account Balance", "Exit");
            _myMenu.title = "Bank Terminal";
            _myMenu.Display();
            Selection();
        }

        //Selection function
        private void Selection()
        {
            int choice = Validation.ValidationInt("\nMake your selection: ");

            switch (choice)
            {
                case 1:
                    Customer();
                    break;
                case 2:
                    CheckingAccount();
                    break;

                case 3:
                    SetBalance();
                    break;

                case 4:
                    DisplayBalance();
                    break;

                case 5:
                    Exit();
                    break;

                default:
                    break;
            }
        }

        string currentCustomer;


        int currentAccountNum;

        decimal currentB;
        decimal currentAccountB = 0.00m;
        decimal currentDisplayB;
        
        private void Customer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Creating Customer:");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Customer c = new Customer(currentCustomer);
            Console.WriteLine("\nPlease type in a customer name: ");
            currentCustomer = Console.ReadLine();
            currentCustomer = Validation.ValidateString(currentCustomer);
            Console.WriteLine($"\n{c.SetCustomerName(currentCustomer)} has been created");
            Console.WriteLine("\n======================");
            Console.WriteLine("========================");

            Console.WriteLine("Press any key to return to the main menu:");

            //// this will pause the program until the user press any key
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void CheckingAccount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Creating Account Number:");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;
            CheckingAccount myChecking = new CheckingAccount(currentAccountNum, currentAccountB);
            Console.WriteLine("\nPlease type in an Account Number: ");
            string currentAccountNumString = Console.ReadLine();
            currentAccountNum = Validation.ValidationInt(currentAccountNumString);

            Console.WriteLine($"Thanks {currentCustomer} your #{myChecking.SetAccountNum(currentAccountNum)} has been created.");

            Console.WriteLine("\n======================");
            Console.WriteLine("=======================");

            Console.WriteLine("Press any key to return to the main menu:");

            //// this will pause the program until the user press any key
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void SetBalance()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Set Balance: ");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;
            SetAccountBalance myBalance = new SetAccountBalance(currentB);
            Console.WriteLine("\nPlease enter a balance: ");
            string currentBalanceString = Console.ReadLine();
            currentB = Validation.ValidationDecimal(currentBalanceString);

            Console.WriteLine($"You have enter: ${myBalance.SetBalance(currentB)}");

            Console.WriteLine("\n======================");
            Console.WriteLine("=======================");

            Console.WriteLine("Press any key to return to the main menu:");

            //// this will pause the program until the user press any key
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void DisplayBalance()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display Balance: ");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.ForegroundColor = ConsoleColor.Gray;
            DisplayBalance myDisplay = new DisplayBalance(currentDisplayB);
            SetAccountBalance myba = new SetAccountBalance(currentB);
            Console.WriteLine(myDisplay.SetDisplayB(myba.GetBalance()));


            Console.WriteLine("\n======================");
            Console.WriteLine("=======================");

            Console.WriteLine("Press any key to return to the main menu:");

            //// this will pause the program until the user press any key
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        private void Exit()
        {
            Console.Clear();

            Console.WriteLine("Thank for banking with us bye!");
            //_myMenu.Display();
            //Selection();
        }

    }
}
