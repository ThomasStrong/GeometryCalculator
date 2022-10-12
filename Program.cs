using System;
using Spectre.Console;

namespace Geometry_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Title = "Awesome, Amazing, Alliterative Geometry Calculator";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            ExitConditional exitCondition = new();
            exitCondition.ToExit = false;

            int counter = 0;
            if (counter == 0)
            {
                MainIntro.UserIntro();
                counter++;
            }

            while (!exitCondition.ToExit)
            {
                if (counter != 1)
                {
                    Console.WriteLine("Press [[Enter]] to continue, or type 'Exit' to close this amazing program.");
                    string line = Console.ReadLine().ToLower();
                    if (line == "exit")
                    {
                        exitCondition.ToExit = true;
                    }
                }
                string sideOptionsTitle = "How many [green]sides[/] to the shape you are working with? [yellow](1-9, or 0 for Other)[/]";
                string[] sideOptions = {
                            "1", "2", "3",
                            "4", "5", "6",
                            "7", "8", "9", "0", "Exit"
                        };
                string sides = MainIntro.UserMenu(sideOptionsTitle, sideOptions);
                bool CanParseSides = int.TryParse(sides, out int numberSides);

                if (sides == "Exit")
                {
                    exitCondition.ToExit = true;
                }
                else if (CanParseSides)
                {
                    Console.WriteLine("Fantastic!  Now, let's see...");
                    ShapeSelector.ShapeHandler(numberSides, exitCondition);

                }
            }
        }
    }
}

