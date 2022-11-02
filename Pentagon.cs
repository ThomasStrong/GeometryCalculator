using System;

namespace Geometry_Calculator
{
    class Pentagon
    {
        public string PentaMethod { get; set; }

        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Pentagons really are underrated.  What shall we figure? (Area, Perimeter)");
        }

        public static void CalcArea()
        {
            Console.WriteLine("We will determine the area of your pentagon.");
            Console.WriteLine("What is the side length of your regular pentagon?");
            string sideLengthString = Console.ReadLine();
            double sideLength = double.Parse(sideLengthString);
            double pentaArea = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(sideLength, 2);
            Console.WriteLine("The area of your pentagon is: " + Math.Round(pentaArea, 2) + " units.  (Rounded to hundredths)");
            Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
            Console.ReadLine();
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Pentagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string pentaSides = Console.ReadLine();
            var pentaP = pentaSides.Split(' ');
            if (pentaP.Length == 5)
            {
                var pentaX = decimal.Parse(pentaP[0]);
                var pentaY = decimal.Parse(pentaP[1]);
                var pentaZ = decimal.Parse(pentaP[2]);
                var pentaA = decimal.Parse(pentaP[3]);
                var pentaB = decimal.Parse(pentaP[4]);
                decimal pentaPerimeter = pentaX + pentaY + pentaZ + pentaA + pentaB;
                Console.WriteLine("The perimeter of your pentagon is: " + pentaPerimeter + " units.");
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ahhh, see we needed 5 sides.  Not whatever it is that you just tried. Laters!");
            }
        }

        public static void PentaMethodHandler(string PentaMethod, ExitConditional exitCondition)
        {
            switch (PentaMethod)
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
