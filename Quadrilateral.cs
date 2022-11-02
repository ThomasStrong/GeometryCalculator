using System;

namespace Geometry_Calculator
{
    class Quadrilateral
    {
        public string QuadMethod { get; set; }

        public static void Intro()
        {
            Console.Clear();
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
                var quadH = decimal.Parse(quadHW[0]);
                var quadW = decimal.Parse(quadHW[1]);
                decimal quadArea = quadH * quadW;
                Console.WriteLine("The area of your rectangle is: " + quadArea + " squared units.");
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else if (quadHW.Length == 1)
            {
                var quadSquare = decimal.Parse(quadHW[0]);

                decimal squareArea = quadSquare * quadSquare;
                Console.WriteLine("The area of your rectangle is: " + squareArea + " squared units.");
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
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
                var squareSide = decimal.Parse(quadP[0]);
                decimal squarePerimeter = squareSide * 4;
                Console.WriteLine("The perimeter of your square is: " + squarePerimeter + " units.");
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else if (quadP.Length == 2)
            {
                var rectH = decimal.Parse(quadP[0]);
                var rectW = decimal.Parse(quadP[1]);
                decimal rectPerimeter = rectH * 2 + rectW * 2;
                Console.WriteLine("The perimeter of your rectangle is: " + rectPerimeter + " units.");
                Console.WriteLine("That'll do. Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else if (quadP.Length == 4)
            {
                var quadOne = decimal.Parse(quadP[0]);
                var quadTwo = decimal.Parse(quadP[1]);
                var quadThree = decimal.Parse(quadP[2]);
                var quadFour = decimal.Parse(quadP[3]);
                decimal quadPerim = quadOne + quadTwo + quadThree + quadFour;
                Console.WriteLine("The perimeter of your quadrilateral is: " + quadPerim + " units.");
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Nope.... Press [Enter] to continue, or type 'Exit' to leave.");
            }
        }

        public static void QuadMethodHandler(string QuadMethod, ExitConditional exitCondition)
        {
            switch (QuadMethod)
            {
                case "area":
                    CalcArea();
                    break;
                case "perimeter":
                    CalcPerimeter();
                    break;
                case "exit":
                    exitCondition.ToExit = true;
                    break;
                default:
                    break;
            }
        }
    }
}
