using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementApp
{
    public class Program
    {
        static List<Movie> movies = new List<Movie>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie App!");

            // Populate sample data
            movies.Add(new Movie("Titanic", 1997));
            movies.Add(new Movie("Tarzen", 1999));
            movies.Add(new Movie("First and Furious", 2001));

            // Implement your menu here
            Console.WriteLine("1. Get all movies");
            Console.WriteLine("2. Get movie by title");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GetAllMovies();
                    break;
                case 2:
                    Console.Write("Enter movie title: ");
                    string title = Console.ReadLine();
                    GetMovieByTitle(title);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        static void GetAllMovies()
        {
            Console.WriteLine("All Movies:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title} ({movie.Year})");
            }
        }

        static void GetMovieByTitle(string title)
        {
            var movie = movies.Find(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (movie != null)
            {
                Console.WriteLine($"Movie Found: {movie.Title} ({movie.Year})");
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }
    }
    class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
    }
}