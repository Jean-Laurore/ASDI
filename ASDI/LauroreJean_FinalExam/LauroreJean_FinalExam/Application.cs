using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace LauroreJean_FinalExam
{
    public class Application
    {
        private string _directory = @"../../../output/";
        private string _fileName = "info.txt";
        private string _jsonFile = "info.json";
        //private List<Movie> _movieCollection = new List<Movie>();
        private Menu _myMenu;
        Dictionary<string, List<Movie>> _movieCollection = new Dictionary<string, List<Movie>>();

        public Application()
        {
            _movieCollection = new Dictionary<string, List<Movie>>();
            _movieCollection.Add("Fantasy", new List<Movie>());
            _movieCollection.Add("Action", new List<Movie>());

            CreatingFile();
            Load();            
            _myMenu = new Menu("Add Movie", "Remove Movie", "Display Movie Genre", "Display All Movies", "Save JSON", "Exit");
            _myMenu.Title = "Jean's Movie Store";
            _myMenu.Display();
            Selection();
        }

        public void Selection()
        {
            int choice = Validation.ValidateInt("\nMake a selection: ");
            if (choice < 1 || choice > 6)
            {
                Console.WriteLine("Invalid Entry. Try again!");
                Selection();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        RemoveMovie();
                        break;
                    case 3:
                        DisplayGenre();
                        break;
                    case 4:
                        DisplayAllMovies();
                        break;
                    case 5:
                        SaveToJSON();
                        break;
                    case 6:
                        Exit();
                        break;
                    default:
                        break;
                }
            }
        }

        public void CreatingFile()
        {
            Directory.CreateDirectory(_directory);

            if (!File.Exists(_directory + _fileName))
            {
                File.Create(_directory + _fileName).Dispose();
                Console.WriteLine("File Created!");

            }
            else
            {
                Console.WriteLine("File exist");
            }
        }

        private void Load()
        {
            using (StreamReader sr = new StreamReader(_directory + _fileName))
            {
                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("fantasy"))
                    {
                        Movie m = new Movie("fantasy", "Star Wars", "Lucas", 88.3m);
                        _movieCollection["Fantasy"].Add(m);
                    }
                    else if (line.Contains("fantasy"))
                    {
                        Movie m2 = new Movie("fantasy", "ET", "Spielberg", 14.2m);
                        _movieCollection["Fantasy"].Add(m2);
                    }
                    else if (line.Contains("action"))
                    {
                        Movie m3 = new Movie("action", "Terminator", "Cameron", 11.2m);
                        _movieCollection["Action"].Add(m3);
                    }
                    else if (line.Contains("action"))
                    {
                        Movie m4 = new Movie("action", "Matrix", "Walchowski", 45.2m);
                        _movieCollection["Action"].Add(m4);
                    }
                }
            }
        }

        public void AddMovie()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Add Movie:");
            Console.WriteLine("==========");
            Console.WriteLine("===========");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nFantasy");
            Console.WriteLine("Action");

            string genre = Validation.ValidateString("\nPlease only write one genre from above: NOTES: case sensitive");
            string name = Validation.ValidateString("\nPlease enter movie name: ");
            string director = Validation.ValidateString("\nPlease enter director name: ");
            decimal cost = Validation.ValidateDecimal("\nPlease enter the cost of the movie: ");


            Movie m = new Movie(genre, name, director, cost);
            if (genre == "Fantasy")
            {
                _movieCollection["Fantasy"].Add(m);
                Console.WriteLine($"You have enter {genre} {name} {director} {cost}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
            else if (genre == "Action")
            {
                _movieCollection["Action"].Add(m);
                Console.WriteLine($"You have enter {genre} {name} {director} {cost}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();
            }
            else
            {
                Console.WriteLine("This genre is not in the dictionary. Try again!");
                AddMovie();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void RemoveMovie()
        {
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove Movie:");
            Console.WriteLine("================");
            Console.WriteLine("================");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (KeyValuePair<string, List<Movie>> kvp in _movieCollection)
            {
                Console.WriteLine(kvp.Key);

                foreach (Movie movie in kvp.Value)
                {
                    Console.WriteLine($"\nGenre:{movie.Genre} Title:{movie.MovieTitle} Director:{movie.Director} Cost:${movie.Cost}");

                }
            }


            //foreach (Movie m in _movieCollection)
            //{
            //    if (m.MovieTitle.Contains(name.ToUpper()))
            //    {
            //        _movieCollection.Remove(m);
            //        m.Terminate();
            //        break;
            //    }
            //}

            string name = Validation.ValidateString("\nPlease enter movie name to remove: ");


            foreach (KeyValuePair<string, List<Movie>> kvp in _movieCollection)
            {
                //Console.WriteLine(kvp.Key);
                
                foreach (Movie movie in kvp.Value)
                {
                    //Console.WriteLine($"\nGenre:{movie.Genre} Title:{movie.MovieTitle} Director:{movie.Director} Cost:${movie.Cost}");
                    if (movie.MovieTitle.Contains(name))
                    {
                        _movieCollection.Remove(name);
                        //movie.Terminate();
                        //break;
                    }
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void DisplayGenre()
        {
            Console.Clear();
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display By Genre:");
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nFantasy");
            Console.WriteLine("Action");

            string genre = Validation.ValidateString("\nPlease enter the genre from above: Notes: case sensitive");
            foreach (KeyValuePair<string, List<Movie>> kvp in _movieCollection)
            {
                if (genre == "Fantasy" && kvp.Key == "Fantasy") 
                {
                    Console.WriteLine(kvp.Key);
                    foreach (Movie movie in kvp.Value)
                {
                    Console.WriteLine($"\nGenre:{movie.Genre} Title:{movie.MovieTitle} Director:{movie.Director} Cost:${movie.Cost}");

                }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    _myMenu.Display();
                    Selection();
                }
                else if (genre == "Action" && kvp.Key == "Action")
                {
                    Console.WriteLine(kvp.Key);
                    foreach (Movie movie in kvp.Value)
                    {
                        Console.WriteLine($"\nGenre:{movie.Genre} Title:{movie.MovieTitle} Director:{movie.Director} Cost:${movie.Cost}");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    _myMenu.Display();
                    Selection();
                }
            }
        }

        public void DisplayAllMovies()
        {
            Console.Clear();
            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display All Movies:");
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.ForegroundColor = ConsoleColor.Gray;

            //if (_movieCollection != null)
            //{
            //    Console.WriteLine("List empty, please add movies to the list");
            //    Console.WriteLine("Press any key to continue...");
            //    Console.ReadKey();
            //    _myMenu.Display();
            //    Selection();
            //}

            
            foreach (KeyValuePair<string, List<Movie>> kvp in _movieCollection)
            {
                Console.WriteLine(kvp.Key);
                foreach (Movie movie in kvp.Value)
                {
                    Console.WriteLine($"\nGenre:{movie.Genre} Title:{movie.MovieTitle} Director:{movie.Director} Cost:${movie.Cost}");
                }
            }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                _myMenu.Display();
                Selection();

        }

        private void SaveToJSON()
        {

            Console.Clear();
            //Setting UI color
            Console.ForegroundColor = ConsoleColor.Green;
            LoadingBar();
            Console.ForegroundColor = ConsoleColor.Gray;

            //CreatingFile();
            using (StreamWriter sw = new StreamWriter(_directory + _jsonFile))
            {
                sw.WriteLine("[");

                int counter = 0;
                foreach (KeyValuePair<string, List<Movie>> kvp in _movieCollection)
                {
                    foreach (Movie movie in kvp.Value)
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"Genre\":\"{kvp.Key}\",");
                        sw.WriteLine($"\"Title\":\"{movie.MovieTitle}\",");
                        sw.WriteLine($"\"Director\":{movie.Director}");
                        sw.WriteLine($"\"Cost\":{movie.Cost}");
                    }

                    if (counter < _movieCollection.Count - 1)
                    {
                        sw.WriteLine("},");
                    }
                    else
                    {
                        sw.WriteLine("}");
                    }
                    counter++;
                }
                sw.WriteLine("]");
            }

            Console.WriteLine("\nSuccessful!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            _myMenu.Display();
            Selection();
        }

        public void LoadingBar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i < 101; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("");
                }
                Console.Write($"SAVING... {i}%");
                Console.SetCursorPosition(1, 1);
                Thread.Sleep(50);
            }
        }

        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for using Jean's Movie Store. GoodBye!");
        }
    }
}
