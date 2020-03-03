using System;

namespace BasicInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");

            d.Load();
            d.Save();
            d.NeedSave = false;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
