using System;
namespace Week2_Day1
{
    public class Song
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public Song()
        {
            Console.WriteLine("Song Created");
        }
    }
}
