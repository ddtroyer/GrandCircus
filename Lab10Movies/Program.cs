using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string answerContinue = null;

            Console.WriteLine("Welcome to the Movie List Application!" + Environment.NewLine);
            Console.WriteLine("There are 100 movies in this list.");

            do
            {
                Console.WriteLine("What category are you interested in?");
                Console.Write("animated, drama, horror, scifi: ");
                string genre = Console.ReadLine();

                List<Movie> MovieList = new List<Movie>() { };
                MovieList = MovieIO.MovieCatalog;
                MovieList= MovieList.Where(mbox=>mbox.genre==genre).OrderBy(mbox => mbox.title).ToList();

                int i = 0;

                foreach (Movie movie in MovieList)
                {                
                    if (movie.genre == genre)
                    {
                        i++;
                        Console.WriteLine(movie.title);
                        if (i >= 10)
                        break;
                    }              
                }
                Console.Write("Continue? (y/n)");
                answerContinue = Console.ReadLine();
            }
            while (answerContinue == "y");
        }
    }
}


