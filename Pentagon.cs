using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Pentagon
    {
        public string PentaMethod { get; set; }

        public static void Intro() =>
            Console.WriteLine("Pentagons really are underrated.  What shall we figure? (Area, Perimeter)");

        public static void CalcArea()
        {
            Console.WriteLine("We will determine the area of your pentagon.");
            Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Pentagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string pentaSides = Console.ReadLine();
            var pentaP = pentaSides.Split(' ');
            if (pentaP.Length == 5)
            {
                var pentaX = Int32.Parse(pentaP[0]);
                var pentaY = Int32.Parse(pentaP[1]);
                var pentaZ = Int32.Parse(pentaP[2]);
                var pentaA = Int32.Parse(pentaP[3]);
                var pentaB = Int32.Parse(pentaP[4]);
                int pentaPerimeter = pentaX + pentaY + pentaZ + pentaA + pentaB;
                Console.WriteLine("The perimeter of your triangle is: " + pentaPerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("Ahhh, see we needed 5 sides.  Not whatever it is that you just tried. Laters!");
            }
        }

        public static void PentaMethodHandler(string PentaMethod)
        {
            switch (PentaMethod)
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
