using System;

namespace Geometry_Calculator
{
    class Hexagon
    {
        public string HexaMethod { get; set; }

        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Mmm, hexagons.  Reminds me of-  well, hexagons I suppose.");
            Console.WriteLine("I can think of a few things to do with a hexagon.... You?  (Area, Perimeter)");
        }

        public static void CalcArea()
        {
            Console.WriteLine("We should determine the area of your hexagon.");
            Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Hexagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string hexSides = Console.ReadLine();
            var hexP = hexSides.Split(' ');
            if (hexP.Length == 6)
            {
                var hexX = decimal.Parse(hexP[0]);
                var hexY = decimal.Parse(hexP[1]);
                var hexZ = decimal.Parse(hexP[2]);
                var hexA = decimal.Parse(hexP[3]);
                var hexB = decimal.Parse(hexP[4]);
                var hexC = decimal.Parse(hexP[5]);
                decimal hexPerimeter = hexX + hexY + hexZ + hexA + hexB + hexC;
                Console.WriteLine("The perimeter of your hexagon is: " + hexPerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("Close, but no cigar!  Need lengths for 6 sides.  Press Enter to leave.");
            }
        }

        public static void HexagonMethodHandler(string HexaMethod)
        {
            switch (HexaMethod)
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
