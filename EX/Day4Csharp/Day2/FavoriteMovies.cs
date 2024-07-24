using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEx.Day2
{
    internal class FavoriteMovies
    {
        List<string> movies = new List<string>();
        public void getMovies()
        {
            Console.WriteLine("Enter the list of movies. Press 'N' to stop entering");
            while (true)
            {
                string movie = Console.ReadLine();
                if(movie.Equals("n") || movie.Equals("N"))
                {
                    break;
                }
                movies.Add(movie);
                
            }
        }

        public void search(string input)
        {
            Console.WriteLine("PartialMatches");
            foreach(string i in movies)
            {
                if (i.Contains(input)){
                    Console.WriteLine(i);
                }
            }
           
        }

        public void exactsearch(string input)
        {
            Console.WriteLine("ExactMatches");
            foreach (string i in movies)
            {
                if (i.Equals(input))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
