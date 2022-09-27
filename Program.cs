﻿using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
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
                int numberSides = Int32.Parse(sides);
                Console.WriteLine("Fantastic!  Now, let's see...");
                ShapeSelector.ShapeHandler(numberSides);


            } while ((line = Console.ReadLine()) != "Exit");
        }
    }
}

