using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Quadrilateral
    {
        public string QuadMethod { get; set; }

        public static void Intro()
        {
            Console.WriteLine("Well, this quadrilateral could be a square or rectangle.  So, we will assume so, thanks.");
            Console.WriteLine("What'll we do with this fancy four-faced figure? (Area, Perimeter)");
        }

        public static void CalcArea()
        {
            Console.WriteLine("We will determine the area of your quadrilateral.");
            Console.WriteLine("Please enter the height and width of the base, or one measurement for a square.");
            string quadFactors = Console.ReadLine();
            var quadHW = quadFactors.Split(' ');

            if (quadHW.Length == 2)
            {
                var quadH = Int32.Parse(quadHW[0]);
                var quadW = Int32.Parse(quadHW[1]);
                int quadArea = quadH * quadW;
                Console.WriteLine("The area of your rectangle is: " + quadArea + " squared units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else if (quadHW.Length == 1)
            {
                var quadSquare = Int32.Parse(quadHW[0]);

                int squareArea = quadSquare * quadSquare;
                Console.WriteLine("The area of your rectangle is: " + squareArea + " squared units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("That was not even close!  That's okay, press Enter to return.");
            }
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your quadrilateral, whether square, rectangle, rhombus, etc.");
            Console.WriteLine("Please enter the lengths of the sides.  One number will calculate for square, 2 numbers will calculate for a rectangle, and 4 numbers for any other");
            string quadPerimeter = Console.ReadLine();
            var quadP = quadPerimeter.Split(' ');
            if (quadP.Length == 1)
            {
                var squareSide = Int32.Parse(quadP[0]);
                int squarePerimeter = squareSide * 4;
                Console.WriteLine("The perimeter of your square is: " + squarePerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else if (quadP.Length == 2)
            {
                var rectH = Int32.Parse(quadP[0]);
                var rectW = Int32.Parse(quadP[1]);
                int rectPerimeter = rectH * 2 + rectW * 2;
                Console.WriteLine("The perimeter of your rectangle is: " + rectPerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else if (quadP.Length == 4)
            {
                var quadOne = Int32.Parse(quadP[0]);
                var quadTwo = Int32.Parse(quadP[1]);
                var quadThree = Int32.Parse(quadP[2]);
                var quadFour = Int32.Parse(quadP[3]);
                int quadPerim = quadOne + quadTwo + quadThree + quadFour;
                Console.WriteLine("The perimeter of your quadrilateral is: " + quadPerim + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("Nope.... Press Enter to stop and restart!");
            }
        }

        public static void QuadMethodHandler(string QuadMethod)
        {
            switch (QuadMethod)
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
