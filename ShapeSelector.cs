using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class ShapeSelector
    {
        public static void ShapeHandler(int numberSides)
        {
            switch (numberSides)
            {
                case 1:
                    Console.WriteLine("Ahh yes, a bright point illuminating a field of darkness.  Anyway, we doin' shapes?");
                    Console.WriteLine("You can always press Enter to leave and try your luck once more!");
                    break;
                case 2:
                    Console.WriteLine("You have found the quickest way from point A to point B.  Or, one side of an as yet unknown shape, but that's not quite enough.");
                    Console.WriteLine("Hows about you press Enter to rerun the simulation.");
                    break;
                case 3:
                    Triangle triangle = new();
                    Triangle.Intro();
                    triangle.TriangleMethod = Console.ReadLine().ToLower();
                    Triangle.TriangleMethodHandler(triangle.TriangleMethod);
                    break;
                case 4:
                    Quadrilateral quadrilateral = new();
                    Quadrilateral.Intro();
                    quadrilateral.QuadMethod = Console.ReadLine().ToLower();
                    Quadrilateral.QuadMethodHandler(quadrilateral.QuadMethod);
                    break;
                case 5:
                    Pentagon pentagon = new();
                    Pentagon.Intro();
                    pentagon.PentaMethod = Console.ReadLine().ToLower();
                    Pentagon.PentaMethodHandler(pentagon.PentaMethod);
                    break;
                case 6:
                    Hexagon hexagon = new();
                    Hexagon.Intro();
                    hexagon.HexaMethod = Console.ReadLine().ToLower();
                    Hexagon.HexagonMethodHandler(hexagon.HexaMethod);
                    break;
                case 7:
                    Septagon septagon = new();
                    Septagon.Intro();
                    septagon.SeptaMethod = Console.ReadLine().ToLower();
                    Septagon.SeptaMethodHandler(septagon.SeptaMethod);
                    break;
                case 8:
                    Octagon octagon = new();
                    Octagon.Intro();
                    octagon.OctaMethod = Console.ReadLine().ToLower();
                    Octagon.OctaMethodHandler(octagon.OctaMethod);
                    break;
                case 9:
                    Nonagon nonagon = new();
                    Nonagon.Intro();
                    nonagon.NonaMethod = Console.ReadLine().ToLower();
                    Nonagon.NonaMethodHandler(nonagon.NonaMethod);
                    break;
                case 0:

                    string otherMethods = Console.ReadLine();
                    Other.OtherMethodHandler(otherMethods);
                    break;
                default:
                    Console.WriteLine("Incorrect input.  Broken now - ");
                    break;
            }
        }
    }
}
