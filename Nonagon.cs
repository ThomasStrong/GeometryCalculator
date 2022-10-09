using System;

namespace Geometry_Calculator
{
    class Nonagon
    {
        public string NonaMethod { get; set; }

        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Nonagons (also enneagons) makes me think it's a none-sided shape.  Anyway, shall we?");
            Console.WriteLine("I think we can do something with you nonagon! (Area, Perimeter)");
        }



        public static void CalcArea()
        {
            Console.WriteLine("We should determine the area of your nonagon.");
            Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
            Console.ReadLine();
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Nonagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string nonSides = Console.ReadLine();
            var nonP = nonSides.Split(' ');
            if (nonP.Length == 9)
            {
                var nonX = decimal.Parse(nonP[0]);
                var nonY = decimal.Parse(nonP[1]);
                var nonZ = decimal.Parse(nonP[2]);
                var nonA = decimal.Parse(nonP[3]);
                var nonB = decimal.Parse(nonP[4]);
                var nonC = decimal.Parse(nonP[5]);
                var nonD = decimal.Parse(nonP[6]);
                var nonE = decimal.Parse(nonP[7]);
                var nonF = decimal.Parse(nonP[8]);
                decimal nonPerimeter = nonX + nonY + nonZ + nonA + nonB + nonC + nonD + nonE + nonF;
                Console.WriteLine("The perimeter of your nonagon is: " + nonPerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("I needed none side!  Haha, anyway, I did need 9 sides.  Press Enter to leave.");
            }
        }

        public static void NonaMethodHandler(string NonaMethod)
        {
            switch (NonaMethod)
            {
                case "area":
                    CalcArea();
                    break;
                case "perimeter":
                    CalcPerimeter();
                    break;
                default:
                    break;
            }
        }
    }
}
