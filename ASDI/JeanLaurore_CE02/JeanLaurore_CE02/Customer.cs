using System;
using System.Collections.Generic;
using DVP1;

// Name: Jean Laurore 
// Date: 2020 - 03
// CE Name: Coding Exercise - Customer
// Synopsis: This class will be use to setting the account balance

namespace JeanLaurore_CE02
{
    public class Customer
    {
        //public List<Customer> myCustomer;


        //Fields
        //public CheckingAccount myCheckingAccount;

        public string name;

        //Contructor
        public Customer(string _name)
        {
            name = _name;
        }

        public string GetCustomerName()
        {
            return name;
        }

        public string SetCustomerName(string _name)
        {
            this.name = _name;
            return name;
        }

        //public void DisplayName()
        //{
        //    Console.Clear();
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("Creating Customer:");
        //    Console.WriteLine("==================");
        //    Console.WriteLine("==================");
        //    Console.ForegroundColor = ConsoleColor.Gray;

        //    Customer customerName = new Customer();
        //    Console.WriteLine("\nPlease type in a customer name: ");
        //    customerName.name = Console.ReadLine();
        //    customerName.name = Validation.ValidateString(customerName.name);

        //    myCustomer = new List<Customer>();
        //    myCustomer.Add(customerName);


        //    //customerName.myCheckingAccount = new CheckingAccount();
        //    //customerName.myCheckingAccount.accountN = myCheckingAccount.accountN;

        //    Console.WriteLine($"\n{customerName.name} has been created");
        //    Console.WriteLine("\n======================");
        //    Console.WriteLine("========================");

        //    Console.WriteLine("Press any key to return to the main menu:");

        //    //// this will pause the program until the user press any key
        //    Console.ReadKey();
        //}
    }
}
