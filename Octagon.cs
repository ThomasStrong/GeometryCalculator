using System;

namespace Geometry_Calculator
{
    class Octagon
    {
        public string OctaMethod { get; set; }

        public static void Intro()
        {
            Console.WriteLine("Octagon and done it again!");
            Console.WriteLine("What are we doing with this eight-sided polygon? (Area, Perimeter)");
        }



        public static void CalcArea()
        {
            Console.WriteLine("We should determine the area of your octagon.");
            Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Octagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string octSides = Console.ReadLine();
            var octP = octSides.Split(' ');
            if (octP.Length == 8)
            {
                var octX = Decimal.Parse(octP[0]);
                var octY = Decimal.Parse(octP[1]);
                var octZ = Decimal.Parse(octP[2]);
                var octA = Decimal.Parse(octP[3]);
                var octB = Decimal.Parse(octP[4]);
                var octC = Decimal.Parse(octP[5]);
                var octD = Decimal.Parse(octP[6]);
                var octE = Decimal.Parse(octP[7]);
                decimal octPerimeter = octX + octY + octZ + octA + octB + octC + octD + octE;
                Console.WriteLine("The perimeter of your octagon is: " + octPerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("That was almost the number of numbers I was hoping to enumerate.  Press Enter to leave.");
            }
        }

        public static void OctaMethodHandler(string OctaMethod)
        {
            switch (OctaMethod)
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
