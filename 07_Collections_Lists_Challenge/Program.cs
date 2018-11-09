using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Challenge
{
    class Program
    {
        static List<StreamContent> movies = new List<StreamContent>();
        static List<StreamContent> shows = new List<StreamContent>();
        static User newUser;
        static StreamContent newContent;
        static bool menu = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo Videos\n");
            RegisterUser();
            AddStreamContent();
            MainMenu();
        }

        static void MainMenu()
        {
            while (menu == true)
            {
                Console.Clear();
                Console.WriteLine("1. Add new movie/show");
                Console.WriteLine("2. See list of streaming content");
                Console.WriteLine("3. Close app");
                int response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        AddStreamContent();
                        break;
                    case 2:
                        StreamContentList();
                        break;
                    case 3:
                        menu = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static void RegisterUser()
        {
            Console.WriteLine("Please enter your full name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            newUser = new User(name, age);
            Console.Clear();
        }

        static void AddStreamContent()
        {
            Console.WriteLine("Is this a movie or a tv show (m/t)?");
            string contentType = Console.ReadLine();
            switch (contentType)
            {
                case "m":
                    AddMovie();
                    break;
                case "t":
                    AddShow();
                    break;
                default:
                    break;
            }
        }

        static void AddMovie()
        {
            Console.WriteLine("Movie Name:");
            string movieName = Console.ReadLine();
            Console.WriteLine("Movie Rating Out of 10:");
            string movieRating = Console.ReadLine();
            Console.WriteLine("Movie Genre:");
            string movieGenre = Console.ReadLine();

            StreamContent newMovie = new StreamContent() {
                ContentName = movieName,
                ContentRating = movieRating,
                ContentGenre = movieGenre
            };

            movies.Add(newMovie);
            Console.WriteLine("Press enter to return to menu...");
            Console.ReadLine();
            menu = true;
            Console.Clear();
        }

        static void AddShow()
        {
            Console.WriteLine("Show Name:");
            string showName = Console.ReadLine();
            Console.WriteLine("Show Rating Out of 10:");
            string showRating = Console.ReadLine();
            Console.WriteLine("Show Genre:");
            string showGenre = Console.ReadLine();
            StreamContent newShow = new StreamContent()
            {
                ContentName = showName,
                ContentRating = showRating,
                ContentGenre = showGenre
            };

            shows.Add(newShow);
            Console.WriteLine("Press enter to return to menu...");
            Console.ReadLine();
            menu = true;
            Console.Clear();
        }

        static void StreamContentList()
        {
            Console.WriteLine($"Streaming list for {newUser.UserName}:");
            Console.WriteLine("Movies:");
            foreach (StreamContent aMovie in movies)
            {
                Console.WriteLine($"\tName:{aMovie.ContentName} - Rating: {aMovie.ContentRating} - Genre: {aMovie.ContentGenre}\n");
            }
            Console.WriteLine("Shows:");
            foreach (StreamContent aShow in shows)
            {
                Console.WriteLine($"\tName:{aShow.ContentName} - Rating: {aShow.ContentRating} - Genre: {aShow.ContentGenre}\n");
            }
            Console.WriteLine("Press enter to return to menu...");
            Console.ReadLine();
            menu = true;
            Console.Clear();

        }
    }
}
