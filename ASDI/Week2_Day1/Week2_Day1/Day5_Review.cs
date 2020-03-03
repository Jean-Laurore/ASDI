using System;
using System.Collections.Generic;

namespace Week2_Day1
{
    public class Day5_Review
    {
        private Dictionary<string, List<Song>> _songList;
        private Menu _myMenu;

        
        public Day5_Review()
        {
            _songList = new Dictionary<string, List<Song>>();
            _songList.Add("Gosh", new List<Song>());
            _songList.Add("Dag-Namit", new List<Song>());
            _songList.Add("Golly-Geez", new List<Song>());

            _myMenu = new Menu("Create Song", "Modify Song", "Display Songs", "Exit");
            _myMenu.Title = "Partially Clothed";
            _myMenu.Display();
            Selection();
        }

        private void Selection()
        {
            int choice = Validation.ValidateInt("Make a selection: ");
            switch (choice)
            {
                case 1:
                    CreateSong();
                    break;

                 case 2:
                    ModifySong();
                    break;

                case 3:
                    DiplaySong();
                    break;

                case 4:
                    Exit();
                    break;

                default:
                    break;
            }
        }

        private void CreateSong()
        {
            Console.Clear();

            string name = Validation.ValidateString("Name of song: ");
            int duration = Validation.ValidateInt("How long is the song: ");


            Song song = new Song();

            song.Title = name;
            song.Duration = duration;

            int counter = 1;
            Console.WriteLine("Albums...");
            string[] temp = new string[_songList.Count];
            foreach (string key in _songList.Keys)
            {
                temp[counter - 1] = key;
                Console.WriteLine($"{counter}. {key}");
                counter++;

            }

            int albumChoice = Validation.ValidateMultiInt("Choose an album to add the song to: ");
            _songList[temp[albumChoice - 1]].Add(song);

            //if (albumChoice == 1)
            //{
                
            //}
            

            Continue("Press any key to continue...");
            Selection();
        }

        private void Continue(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

       
        private void ModifySong()
        {

        }

        private void DiplaySong()
        {
            Console.Clear();
            Console.WriteLine("My songs==================");


            foreach (KeyValuePair<string, List<Song>> kvp in _songList)
            {
                Console.WriteLine(kvp.Key);
                foreach (Song song in kvp.Value)
                {
                    Console.WriteLine(song.Title);
                }
            }
            Continue("That's cool...");
            Selection();
        }

        private void Exit()
        {

        }

    }
}
