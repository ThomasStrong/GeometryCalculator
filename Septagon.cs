using System;


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
                var septX = Decimal.Parse(septP[0]);
                var septY = Decimal.Parse(septP[1]);
                var septZ = Decimal.Parse(septP[2]);
                var septA = Decimal.Parse(septP[3]);
                var septB = Decimal.Parse(septP[4]);
                var septC = Decimal.Parse(septP[5]);
                var septD = Decimal.Parse(septP[6]);
                decimal septPerimeter = septX + septY + septZ + septA + septB + septC + septD;
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
