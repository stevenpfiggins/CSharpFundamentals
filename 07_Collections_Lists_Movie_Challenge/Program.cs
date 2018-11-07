using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Movie_Challenge
{
    class Program
    {
        static User userOne = new User();
        static void Main(string[] args)
        {
            string userAgeString;

            Console.WriteLine("Welcome to Komodo Watch List!");
            Console.WriteLine("Please register by completing the information below.");
            Console.WriteLine("What is your name?");
            userOne.UserName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            userAgeString = Console.ReadLine();
            userOne.UserAge = int.Parse(userAgeString);
            Console.Clear();
            Console.WriteLine("Do you want to add a movie or TV show to your list? (y/n)");
            bool addingVideos = CheckAnswer();
            while (addingVideos)
            {
                AddVideo();
                Console.WriteLine("Would you like to add another movie or TV show? (y/n)");
                addingVideos = CheckAnswer();
            }
            if (userOne.VideoList.Count != 0)
            {
                ListVideos();
            }

            Console.ReadLine();
        }

        static void AddVideo()
        {
            Video newVideo = new Video();
            Console.WriteLine("Please add a movie or TV show to your list.");
            Console.WriteLine("What is the title of the item?");
            newVideo.Title = Console.ReadLine();
            Console.WriteLine("Is it a movie or TV show?");
            newVideo.Type = Console.ReadLine();
            Console.WriteLine("What genre is this item?");
            newVideo.Genre = Console.ReadLine();
            Console.WriteLine("What rating do you give this item (Out of 10)?");
            string ratingString = Console.ReadLine();
            newVideo.Rating = float.Parse(ratingString);

            userOne.VideoList.Add(newVideo);
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

        static void ListVideos()
        {
            Console.WriteLine("Here is a list of the videos you want to watch!");
            foreach (Video videos in userOne.VideoList)
            {
                Console.WriteLine($"\t" + $"Title: {videos.Title}\n\t" +
                    $"Genre: {videos.Genre}\n\t" +
                    $"Rating: {videos.Rating}\n\t" +
                    $"Type: {videos.Type}");
            }
        }
    }
}
