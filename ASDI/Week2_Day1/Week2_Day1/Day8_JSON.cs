//using System;
//using System.Collections.Generic;
//using System.IO;
//namespace Week2_Day1
//{
//    public class Day8_JSON
//    {
//        private string _directory = @"../../../output/";
//        private string _fileName = "data.json";
//        private List<Employee> _employee = new List<Employee>();

//        public Day8_JSON()
//        {

//            //Adding employee to the list of Employee
//            Employee emp1 = new Employee("Bob", 31, 60000);
//            Employee emp2 = new Employee("John", 35, 65000);
//            Employee emp3 = new Employee("Mary", 24, 80000);

//            _employee.Add(emp1);
//            _employee.Add(emp2);
//            _employee.Add(emp3);

//            Directory.CreateDirectory(_directory);
//            if (!File.Exists(_directory + _fileName))
//            {
//                File.Create(_directory + _fileName).Dispose();
//            }
//            else
//            {
//                Console.WriteLine("File created!");
//            }

//            SaveToJSON();

//        }

//        private void SaveToJSON()
//        {
//            using (StreamWriter streamW = new StreamWriter(_directory + _fileName))
//            {
//                streamW.WriteLine("[");

//                int counter = 0;
//                foreach (Employee employee in _employee)
//                {
//                    streamW.WriteLine("{");
//                    streamW.WriteLine($"\"name\":\"{employee.Name}\",");
//                    streamW.WriteLine($"\"age\":{employee.Age},");
//                    streamW.WriteLine($"\"salary\":{employee.Salary}");

//                    if (counter < _employee.Count -1)
//                    {
//                        streamW.WriteLine("},");

//                    }
//                    else
//                    {
//                        streamW.WriteLine("}");
//                    }
//                    counter++;

//                }
//                streamW.WriteLine("]");


//            }
//        }
//    }
//}
