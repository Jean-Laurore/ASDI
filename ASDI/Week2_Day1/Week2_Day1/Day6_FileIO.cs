using System;
using System.IO;
using System.Collections.Generic;

namespace Week2_Day1
{
    public class Day6_FileIO
    {
        private string _directory = @"../../../pizza/";
        private string _fileName = "data.txt"; //To add inside the pizza folder.
        private List<Vehicle> _vehicle = new List<Vehicle>();

        public Day6_FileIO()
        {

            // @ is a verbatim symbol. treat string exactly
            Directory.CreateDirectory(_directory);

            if (!File.Exists(_directory + _fileName))
            {
                File.Create(_directory + _fileName).Dispose(); //Will add the the txt insdie the folder.
                Console.WriteLine("File Created!");

            }
            else
            {
                Console.WriteLine("File exist");
            }
            Load();


            //Create a file inside directory



            //Need an object
            //Spiderman spidey = new Spiderman();
            //spidey.Name = "Peter Parker";

            //Superman surper = new Superman();
            //surper.Name = "Clark Kent";

            //Console.WriteLine(spidey.Sleep());
            //Console.WriteLine("Superman " + surper.Sleep());
            //Console.WriteLine("Superman Powers " + surper.PerformPower());
            //Console.WriteLine("SPidermsn power" + spidey.PerformPower());
        }
            private void Save()
            {
            using (StreamWriter streamW = new StreamWriter(_directory + _fileName))
            {
                streamW.WriteLine("I love pizza!");

            }

            }
        private void Load()
        {
            Console.Clear();
            using (StreamReader sr = new StreamReader(_directory + _fileName))
            {
                //string line1 = sr.ReadLine();
                //string line2 = sr.ReadLine();
                //string line3 = sr.ReadLine();
                //Console.WriteLine(line1);
                //Console.WriteLine(line2);
                //Console.WriteLine(line3);


                // show line 8
                //sr.ReadLine();
                //sr.ReadLine();
                //sr.ReadLine();
                //sr.ReadLine();
                //sr.ReadLine();
                //sr.ReadLine();
                //sr.ReadLine();

                //Console.WriteLine(sr.ReadLine());
                //end

                // Keep on reading stuff in the stream
                //while (sr.Peek() > -1)
                //{
                //    Console.WriteLine(sr.Peek() + " " + sr.ReadLine());
                //}

                while (sr.Peek() > -1)
                {
                string line = sr.ReadLine();
                if (line.StartsWith('C'))
                {
                    Car car = new Car(line);
                    _vehicle.Add(car);
                }
                else if (line.StartsWith('B'))
                {
                    Boat boat = new Boat(line);
                    _vehicle.Add(boat);
                }
                }


                // If the firt character of string from the streamReader is a "C" then create a new car

                DisplayVehicles();

                
            }
            
        }

        private void AddCar()
        {
            Console.Clear();

            string make = Validation.ValidateString("Make: ");
            string model = Validation.ValidateString("Model:");
            int price = Validation.ValidateInt("Price: ");
            int mpg = Validation.ValidateInt("MPG: ");

            Car car = new Car(make, model, price, mpg);
        }

        private void DisplayVehicles()
        {
            foreach (Vehicle item in _vehicle)
            {
                if (item is Car)
                {
                    Console.WriteLine("Car");
                    //casting to make sure it a car
                    Console.Write(((Car)item).Make + " ");
                    Console.WriteLine(((Car)item).Model);
                }
                else if (item is Boat)
                {
                    Console.WriteLine("Boat");
                    Console.WriteLine(((Boat)item).Model);
                    Console.WriteLine(((Boat)item).EngineCount);
                }
            }
        }
    }
}