using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    public class Triangle
    {
        public string TriangleMethod { get; set; }

        public static void Intro() =>
            Console.WriteLine("A triangle!  Yes, we like triangles.  What shall we do? (Area, Perimeter)");

        public static void CalcArea()
        {
            Console.WriteLine("We will determine the area of your triangle.");
            Console.WriteLine("Please enter the height and width of the base");
            string triangleFactors = Console.ReadLine();
            var factorsHW = triangleFactors.Split(' ');

            if (factorsHW.Length == 2)
            {
                var triangleH = Int32.Parse(factorsHW[0]);
                var triangleW = Int32.Parse(factorsHW[1]);
                int triangleArea = triangleH * triangleW / 2;
                Console.WriteLine("The area of your triangle is: " + triangleArea + " squared units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("We were almost there!  Press Enter to leave and begin again!");
            }
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your triangle.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string triangleSides = Console.ReadLine();
            var factorsP = triangleSides.Split(' ');
            if (factorsP.Length == 3)
            {
                var triangleX = Int32.Parse(factorsP[0]);
                var triangleY = Int32.Parse(factorsP[1]);
                var triangleZ = Int32.Parse(factorsP[2]);
                int trianglePerimeter = triangleX + triangleY + triangleZ;
                Console.WriteLine("The perimeter of your triangle is: " + trianglePerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
            }
            else
            {
                Console.WriteLine("Nope.... Press Enter to stop and restart!");
            }
        }

        public static void TriangleMethodHandler(string TriangleMethod)
        {
            switch (TriangleMethod)
            {
                case "Area":
                    Triangle.CalcArea();
                    break;
                case "Perimeter":
                    Triangle.CalcPerimeter();
                    break;
            }
        }
    }
}