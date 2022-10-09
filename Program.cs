﻿using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Awesome, Amazing, Alliterative Geometry Calculator";
            Console.ForegroundColor = ConsoleColor.White;

            int counter = 0;
            if (counter == 0)
            {
                MainIntro.UserIntro();
                counter++;
            }

            string line;
            do
            {
                if (counter != 1)
                {
                    Console.WriteLine("Press Enter to continue, or type 'Exit' to close this amazing program.");
                    line = Console.ReadLine();
                }

                Console.WriteLine("How many sides to the shape you are working with? (1-9, or 0 for Other)");
                string sides = Console.ReadLine();
                bool CanParseSides = int.TryParse(sides, out int numberSides);
                if (CanParseSides)
                {
                    Console.WriteLine("Fantastic!  Now, let's see...");
                    ShapeSelector.ShapeHandler(numberSides);
                }
                else
                {
                    Console.WriteLine("That wasn't quite right.  Please press 'Enter' to try again.");
                }




            } while ((line = Console.ReadLine()) != "Exit");
        }
    }
}

