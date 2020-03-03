using System;

// Name: Jean Laurore 
// Date: 2020 - 01
// CE Name: Coding Exercise - Validation
// Synopsis: This class will be use to valid input

namespace DVP1
{
    public class Validation
    {
        //Validate an int
        public static int ValidationInt(string userInt)
        {
            int validNum;
            while (!int.TryParse(userInt, out validNum))
            {
                Console.WriteLine("\nPlease enter a valid integer: ");
                userInt = Console.ReadLine();
            }
            return validNum;
        }

        //Validate Double
        public static double ValidationDouble(string userDouble)
        {
            double validNum;
            while (!double.TryParse(userDouble, out validNum))
            {
                Console.WriteLine("\nPlease enter a valid integer: ");
                userDouble = Console.ReadLine();
            }
            return validNum;
        }

        //Validate a decimal
        public static decimal ValidationDecimal(string userDecimal)
        {
            decimal validNum;
            while (!decimal.TryParse(userDecimal, out validNum))
            {
                Console.WriteLine("\nPlease enter a valid integer: ");
                userDecimal = Console.ReadLine();
            }
            return validNum;
        }

        //Validate a float
        public static float ValidationFloat(string userFloat)
        {
            float validNum;
            while (!float.TryParse(userFloat, out validNum))
            {
                Console.WriteLine("\nPlease enter a valid integer: ");
                userFloat = Console.ReadLine();
            }
            return validNum;
        }


        //Validate an string
        // String Required
        public static string ValidateString(string s)
        {
            while (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("\r\nPlease do not leave this empty. Try again: ");
                s = Console.ReadLine();
            }
            return s;
        }
    }
}