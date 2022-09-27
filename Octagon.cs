using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var octX = Int32.Parse(octP[0]);
                var octY = Int32.Parse(octP[1]);
                var octZ = Int32.Parse(octP[2]);
                var octA = Int32.Parse(octP[3]);
                var octB = Int32.Parse(octP[4]);
                var octC = Int32.Parse(octP[5]);
                var octD = Int32.Parse(octP[6]);
                var octE = Int32.Parse(octP[7]);
                int octPerimeter = octX + octY + octZ + octA + octB + octC + octD + octE;
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
