using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Hexagon
    {
        public string HexaMethod { get; set; }

        public static void Intro()
        {
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
                var hexX = Int32.Parse(hexP[0]);
                var hexY = Int32.Parse(hexP[1]);
                var hexZ = Int32.Parse(hexP[2]);
                var hexA = Int32.Parse(hexP[3]);
                var hexB = Int32.Parse(hexP[4]);
                var hexC = Int32.Parse(hexP[5]);
                int hexPerimeter = hexX + hexY + hexZ + hexA + hexB + hexC;
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
                case "Area":
                    CalcArea();
                    break;
                case "Perimeter":
                    CalcPerimeter();
                    break;
                default:
                    break;
            }
        }
    }
}
