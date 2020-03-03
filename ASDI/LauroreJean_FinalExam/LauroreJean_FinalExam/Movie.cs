using System;
namespace LauroreJean_FinalExam
{
    public class Movie
    {
        public string MovieTitle { get; set; }
        public decimal Cost { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }

        public Movie(string genre, string movieT, string director, decimal cost)
        {
            Genre = genre;
            MovieTitle = movieT;
            Director = director;
            Cost = cost;
        }

        public virtual decimal TotalCost()
        {
            //decimal total =
            return + Cost;
        }

        public void Terminate()
        {
            Console.WriteLine("Successful remove");
        }
    }
}
