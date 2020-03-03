using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1,7));
            //List
            List<int> grades = new List<int>() {20, 30, 40 };
            List<string> names = new List<string>() { "BOB", "JEAN", "BOSS" };
            grades.Add(100);
            grades.Remove(0);
            //Console.WriteLine(grades[1]);


            //Making number stay in the same column
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{names[i],-20} {grades[i]}");
            }

            //int index = 1;
            //foreach (int item in grades)
            //{
            //    Console.WriteLine($"{index}:{item}");
            //    index++;
            //}
        }
    }
}
