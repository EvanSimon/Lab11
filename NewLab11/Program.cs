using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            
            while(run == true)
            {
                int choice;
                Movie[] movieList = FillMovieList();
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("");
                Console.WriteLine("If you would like to se our movies please pick a catagory:");
                Console.WriteLine("Press: 1 for Action:");
                Console.WriteLine("Press: 2 for Animation:");
                Console.WriteLine("Press: 3 for Comedy:");
                Console.WriteLine("Press: 4 for Drama:");
                Console.WriteLine("Press: 5 for Horror:");

                choice = UserActions();
                ReturnMovies(choice, movieList);

                Console.WriteLine("");
                Console.Write("Continue?");
               run = YesOrNo();
            }
        }
        private static void ReturnMovies(int choice, Movie[] movieList)
        {

            switch (choice)
            {
                case 1:
                    PullMovieFromList(movieList, "Action");
                    break;
                case 2:
                    PullMovieFromList(movieList, "Animation");
                    break;
                case 3:
                    PullMovieFromList(movieList, "Comedy");
                    break;
                case 4:
                    PullMovieFromList(movieList, "Drama");
                    break;
                case 5:
                    PullMovieFromList(movieList, "Horror");
                    break;
                default:
                    break;
            }
        }

        private static void PullMovieFromList(Movie[] movieList, string catagory)
        {
            
            List<String> titleList = new List<string> { };
            foreach (Movie title in movieList)
            {
                if (title.GetCategory() == catagory)
                    titleList.Add(title.GetTitle());
            }
            titleList.Sort();
            foreach (string title in titleList)
            {
                Console.WriteLine(title);
            }
        }

        public static int UserActions()
        {

            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (input == 1)
                {
                    Console.WriteLine("You chose Action!");
                    return 1;
                }
                else if (input == 2)
                {
                    Console.WriteLine("You chose Animation!");
                    return 2;
                }
                else if (input == 3)
                {
                    Console.WriteLine("You chose Comedy!");
                    return 3;
                }
                else if (input == 4)
                {
                    Console.WriteLine("You chose Drama!");
                    return 4;
                }
                else if (input == 5)
                {
                    Console.WriteLine("You chose Horror!");
                    return 5;
                }
                else
                {
                    Console.WriteLine("I'm sorry you must enter a number between 1-5");
                }

            }
        }

        private static bool YesOrNo()
        {
            string input;
            while (true)
            {
                Console.Write("(y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry!");
                    continue;
                }
            }
        }

        private static Movie[] FillMovieList()
        {
            Movie[] movieList =
            {
               new Movie("Black Panther", "Action"),
               new Movie("A Star is Born", "Drama"),
               new Movie("Citizen Kane", "Drama"),
               new Movie("Blackkklansman", "Comedy"),
               new Movie("Mad Max: Fury Road", "Action"),
               new Movie("Friday The 13th" , "Horror"),
               new Movie("The Exorcist" , "Horror"),
               new Movie("Texas Chainsaw Massacre" , "Horror"),
               new Movie("Sorry to Bother You" , "Comedy"),
               new Movie("Can You Ever Forgive Me", "Comedy"),
               new Movie("Mission Impossible: Fallout", "Action"),
               new Movie("Young Frankinstien", "Comedy"),
               new Movie("Ghost in the Shell", "Animation"),
               new Movie("Akira", "Animation"),
               new Movie("Venom", "Action"),
               new Movie("Leave No Trace", "Drama"),
               new Movie("Burning", "Drama"),
               new Movie("Vice", "Comedy"),
               new Movie("Deadpool 2", "Action"),
               new Movie("Aladdin", "Animation")
            };
            return movieList;
        }

    }
}
