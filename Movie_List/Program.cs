using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_List
{
    class Program
    {
        static Person userOne = new Person();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Movie List!");
            RegisterUser();
            Console.Clear();
            Console.WriteLine("Do you have a favorite movie? (y/n)");
            bool addingMovies = CheckAnswer();
            while (addingMovies)
            {
                AddMovie();
                Console.WriteLine("Do you want to add another movie? (y/n)");
                addingMovies = CheckAnswer();
            }

            if (userOne.MovieList.Count != 0)
            {
                ListMovies();
            }

            Console.ReadLine();
            


        }

        static void RegisterUser()
        {
            Console.WriteLine("Please register by providing the following information.");
            Console.WriteLine("What is your first name?");
            userOne.UserFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            userOne.UserLastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            userOne.UserAge = ParseStringToInt();
            Console.Clear();
            Console.WriteLine($"Thank you for registering, {userOne.UserLastName}!");

        }

        static void AddMovie()
        {
            Movie favoriteMovie = new Movie();
            Console.WriteLine("What is the title of the movie?");
            favoriteMovie.MovieTitle = Console.ReadLine();
            Console.WriteLine("What is the genre of the movie?");
            favoriteMovie.MovieGenre = Console.ReadLine();
            Console.WriteLine("What is the rating of the movie?");
            favoriteMovie.MovieRating = Console.ReadLine();
            userOne.MovieList.Add(favoriteMovie);
        }

        static int ParseStringToInt()
        {
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);
            return input;
        }

        static bool CheckAnswer()
        {
            bool isValid = false;
            while (!isValid)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            return false;
        }

        static void ListMovies()
        {
            Console.WriteLine($"Here are {userOne.UserFirstName}'s favorite movies!");
            foreach (Movie movie in userOne.MovieList)
            {
                Console.WriteLine($"\t" + "Title: {movie.MovieTitle}\n\t" +
                    $"Genre: {movie.MovieGenre}\n\t" +
                    $"Rating: {movie.MovieRating}");
            }
        }

    }
}
