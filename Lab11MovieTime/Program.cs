using System;
using System.Collections.Generic;

namespace Lab11MovieTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies newMovie = new Movies("Texas Chainsaw Massacre", "Horror");
            List<Movies> moviesList = new List<Movies>
            {
                new Movies("Saw", "Horror"),
                new Movies("Saw II", "Horror"),
                new Movies("Saw III", "Horror"),
                new Movies("Saw IV", "Horror"),
                new Movies("Saw V", "Horror"),
                new Movies("Transformers", "SciFi"),
                new Movies("Transformers: Revenge of the Fallen", "SciFi"),
                new Movies("Transformers: Dark Side of the Moon", "SciFi"),
                new Movies("The Boondock Saints", "Action"),
                new Movies("Finding Nemo", "Animated")
            };
            bool go = true;
            while (go)
            {
            Console.WriteLine("     Welcome to the movie directory!");
            Console.WriteLine("");
            Console.WriteLine("     ============================== ");
            Console.WriteLine("");
            Console.WriteLine("       What type of movie are you");
            Console.WriteLine("         interested in watching? ");
            Console.WriteLine("");
            Console.WriteLine("     ============================== ");
            Console.WriteLine("");
            Movies.DisplayMenu();

            
            
            string menuChoiceTyped = Console.ReadLine().ToLower();

                foreach (var movie in moviesList)
                {

                    if (menuChoiceTyped == "1" || menuChoiceTyped == "Horror")
                    {
                        if (movie.Category == "Horror")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else if (menuChoiceTyped == "2" || menuChoiceTyped == "SciFi")
                    {
                        if (movie.Category == "SciFi")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else if (menuChoiceTyped == "3" || menuChoiceTyped == "Action")
                    {
                        if (movie.Category == "Action")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else if (menuChoiceTyped == "4" || menuChoiceTyped == "Animated")
                    {
                        if (movie.Category == "Animated")
                        {
                            Console.WriteLine(movie.Title);
                        }
                    }
                    else if (menuChoiceTyped == "5" || menuChoiceTyped == "Quit")
                    {
                        Console.WriteLine("Thanks for using the movie selector!");
                        Console.WriteLine("        =====Goodbye=====           ");
                        go = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid selection.");
                    }
                }       
            }
        }
        
    }
}
