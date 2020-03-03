using System;
using System.Collections.Generic;
using DVP1;

// Name: Jean Laurore 
// Date: 2020 - 03
// CE Name: Coding Exercise - Checking Account
// Synopsis: This class will be use to contains a balance.

namespace JeanLaurore_CE02
{
    public class CheckingAccount
    {
        //public Customer customerList;

        //public List<CheckingAccount> _checking;
        //Member var
        public decimal accountB = 0.00m;
        public int accountN;
        public string accountNString;


        public CheckingAccount(int _accountN, decimal _accountB) 
        {
            //Use the incoming parameters to initialize our original member variables
            accountN = _accountN;
            accountB = _accountB;
        }

        public int GetAccountNum()
        {
            return accountN;
        }

        public int SetAccountNum(int _accountNum)
        {
            this.accountN = _accountNum;
            return accountN;
        }

        public decimal GetAccountB()
        {
            return accountB;
        }

        public decimal SetAccountB(decimal _accountB)
        {
            this.accountB = _accountB;
            return accountB;
        }

        //public void DisplayAccount()
        //{
        //    Console.Clear();
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("Creating Account:");
        //    Console.WriteLine("=================");
        //    Console.WriteLine("=================");
        //    Console.ForegroundColor = ConsoleColor.Gray;


        //    //Console.WriteLine("\nPlease type in an Account Number: ");
        //    //myChecking.accountNString = Console.ReadLine();
        //    //myChecking.accountN = Validation.ValidationInt(myChecking.accountNString);


        //    //Console.WriteLine($"Thanks {customerList.name} your #{myChecking.accountN} has been created.");

        //    Console.WriteLine("\n======================");
        //    Console.WriteLine("=======================");

        //    Console.WriteLine("Press any key to return to the main menu:");

        //    //// this will pause the program until the user press any key
        //    Console.ReadKey();
        //}
    }
}
