using Spectre.Console;
using System;

namespace Geometry_Calculator
{
    public class Triangle
    {
        public string TriangleMethod { get; set; }

        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("A triangle!  Yes, we like triangles.  What shall we do? (Area, Perimeter)");
            AnsiConsole.Markup("AREA:  1/2[yellow]H[/][blue]W[/]   PERIMETER:  [blue]S[/]+[blue]S[/]+[blue]S[/]    \n");
            AnsiConsole.Markup(" \n");
            AnsiConsole.Markup("  [yellow]H->[/]  /[yellow]|[/]\\         [blue]S->  /[/]\\   \n");
            AnsiConsole.Markup("  [blue]W->[/] / [yellow]|[/] \\            [blue]/[/]  \\  \n");
            AnsiConsole.Markup("     /[blue]__[/][yellow]|[/][blue]__[/]\\          [blue]/[/]____\\ \n");

        }

        public static void CalcArea()
        {
            Console.WriteLine("We will determine the area of your triangle.");
            AnsiConsole.Markup("Please enter the [yellow]H[/]eight and [blue]W[/]idth of the base--> ");
            string triangleFactors = Console.ReadLine();
            var factorsHW = triangleFactors.Split(' ');

            if (factorsHW.Length == 2)
            {
                var triangleH = decimal.Parse(factorsHW[0]);
                var triangleW = decimal.Parse(factorsHW[1]);
                decimal triangleArea = triangleH * triangleW / 2;
                Console.WriteLine("The area of your triangle is: " + triangleArea + " squared units.");
                Console.WriteLine("That'll do.  Press Enter to continue, or type 'Exit' to leave.");
            }
            else
            {
                Console.WriteLine("We were almost there!  Press Enter to leave and begin again!");
            }
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your triangle.");
            AnsiConsole.Markup("Please enter the lengths of the [blue]S[/]ides.\n");
            string triangleSides = Console.ReadLine();
            var factorsP = triangleSides.Split(' ');
            if (factorsP.Length == 3)
            {
                var triangleX = decimal.Parse(factorsP[0]);
                var triangleY = decimal.Parse(factorsP[1]);
                var triangleZ = decimal.Parse(factorsP[2]);
                decimal trianglePerimeter = triangleX + triangleY + triangleZ;
                Console.WriteLine("The perimeter of your triangle is: " + trianglePerimeter + " units.");
                Console.WriteLine("That'll do.  Press Enter to continue, or type 'Exit' to leave.");
            }
            else
            {
                Console.WriteLine("Nope.... Press Enter to stop and restart!");
            }
        }

        public static void TriangleMethodHandler(string TriangleMethod, ExitConditional exitCondition)
        {
            switch (TriangleMethod)
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