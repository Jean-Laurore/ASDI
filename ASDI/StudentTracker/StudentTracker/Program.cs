using System;

namespace StudentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Option myOption = new Option();

            //int[] numbers = { 5, 6, 7, 8, 10, 12, 14, 23, 35, 50 };

            //double average = AverageTheNumber(numbers);

            //Console.WriteLine("The average of the array is " + average);
        }

        public static double AverageTheNumber(int[] numbers)
        {
            //create an int array of 10 numbers
            //int[] numbers = { 5, 6, 7, 8, 10, 12, 14, 23, 35, 50 };
            double total = 0;
            // create a for loop to cycle through the elemens
            for (int x = 0; x < numbers.Length; x++)
            {
                total += numbers[x];
            }

            //return
            return total / numbers.Length;
        }
    }
}
