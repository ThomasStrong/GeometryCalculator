using System;


namespace Geometry_Calculator
{
    class Septagon
    {
        public string SeptaMethod { get; set; }

        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("The infamous seven-sided triangle!  Just kidding, we're looking at a septagon (or heptagon if that makes you heppy).  But why?");
            Console.WriteLine("Don't see many of these.  Need?  (Area, Perimeter)");
        }



        public static void CalcArea()
        {
            Console.WriteLine("We should determine the area of your septagon.");
            Console.WriteLine("What is the side length of your regular septagon?");
            string sideLengthString = Console.ReadLine();
            double sideLength = double.Parse(sideLengthString);
            double septCoefficient = 3.634;
            double septArea = septCoefficient * Math.Pow(sideLength, 2);
            Console.WriteLine("The area of your regular hexagon is: " + Math.Round(septArea, 2) + " units.  (Rounded to hundredths)");
            Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
            Console.ReadLine();
        }

        public static void CalcPerimeter()
        {
            Console.WriteLine("We will determine the perimeter of your Septagon.");
            Console.WriteLine("Please enter the lengths of the sides.");
            string septSides = Console.ReadLine();
            var septP = septSides.Split(' ');
            if (septP.Length == 7)
            {
                var septX = decimal.Parse(septP[0]);
                var septY = decimal.Parse(septP[1]);
                var septZ = decimal.Parse(septP[2]);
                var septA = decimal.Parse(septP[3]);
                var septB = decimal.Parse(septP[4]);
                var septC = decimal.Parse(septP[5]);
                var septD = decimal.Parse(septP[6]);
                decimal septPerimeter = septX + septY + septZ + septA + septB + septC + septD;
                Console.WriteLine("The perimeter of your septagon is: " + septPerimeter + " units.");
                Console.WriteLine("That'll do.  Press [Enter] to continue, or type 'Exit' to leave.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Yeah, sorry.  I need 7 numbers for that.  Press [Enter] to leave.");
            }
        }

        public static void SeptaMethodHandler(string SeptaMethod, ExitConditional exitCondition)
        {
            switch (SeptaMethod)
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
