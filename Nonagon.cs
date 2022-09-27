using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Nonagon
    {
        public string NonaMethod { get; set; }

        public static void Intro()
        {
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
                var nonX = Int32.Parse(nonP[0]);
                var nonY = Int32.Parse(nonP[1]);
                var nonZ = Int32.Parse(nonP[2]);
                var nonA = Int32.Parse(nonP[3]);
                var nonB = Int32.Parse(nonP[4]);
                var nonC = Int32.Parse(nonP[5]);
                var nonD = Int32.Parse(nonP[6]);
                var nonE = Int32.Parse(nonP[7]);
                var nonF = Int32.Parse(nonP[8]);
                int nonPerimeter = nonX + nonY + nonZ + nonA + nonB + nonC + nonD + nonE + nonF;
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
