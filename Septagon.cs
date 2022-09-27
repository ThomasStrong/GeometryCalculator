using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Septagon
    {
        public string SeptaMethod { get; set; }

        public static void Intro()
        {
            Console.WriteLine("The infamous seven-sided triangle!  Just kidding, we're looking at a septagon.  But why?");
            Console.WriteLine("Don't see many of these.  Need?  (Area, Perimeter)");
        }



        public static void CalcArea()
        {
            Console.WriteLine("We should determine the area of your septagon.");
            Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Septagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string septSides = Console.ReadLine();
            var septP = septSides.Split(' ');
            if (septP.Length == 7)
            {
                var septX = Int32.Parse(septP[0]);
                var septY = Int32.Parse(septP[1]);
                var septZ = Int32.Parse(septP[2]);
                var septA = Int32.Parse(septP[3]);
                var septB = Int32.Parse(septP[4]);
                var septC = Int32.Parse(septP[5]);
                var septD = Int32.Parse(septP[6]);
                int septPerimeter = septX + septY + septZ + septA + septB + septC + septD;
                Console.WriteLine("The perimeter of your septagon is: " + septPerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("Yeah, sorry.  I need 7 numbers for that.  Press Enter to leave.");
            }
        }

        public static void SeptaMethodHandler(string SeptaMethod)
        {
            switch (SeptaMethod)
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
