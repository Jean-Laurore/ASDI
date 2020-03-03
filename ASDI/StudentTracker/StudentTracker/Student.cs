using System;
namespace StudentTracker
{
    public class Student
    {
        public string Name { get; set; }
        public string Degree { get; set; }
        //public int[] grades;
        //public double amount;
        //public double avg;
        //public int random;
        //public int random1;
        //public int random2;

        public Student()
        {
            Console.WriteLine("Student created!");
            //Degree = degree;
        }
        //public void GenerateGrade()
        //{
        //    Random myRandom = new Random();
        //    random = myRandom.Next(0, 80);
        //    random1 = myRandom.Next(0, 80);
        //    random2 = myRandom.Next(0, 80);
        //    amount = (random + random1 + random2);
        //    avg = amount / 3;
        //    Console.WriteLine($"{"  "} {"Grades",-15} {"Average",-18}");
        //    Console.WriteLine($"{"   "}{random} {random1} {random2} {"", -9}{avg.ToString("0")}");

        //}
    }
}
