using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Awesome, Amazing, Alliterative Geometry Calculator!");
            Console.WriteLine("We are here to provide the best in geometric calculations!  Stand by for awesomeness...");

            /*  Console.WriteLine("");   <<<< Template*/

            Console.WriteLine("While we are waiting, may I get your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Great, thanks " + name + "!  We are legion.");
            Console.WriteLine("Uhh *cough* that is- I mean how can we help you with geometry?");
            Console.WriteLine("How many sides to the shape you are working with? (1-9, or 0 for Other");
            string sides = Console.ReadLine();
            int numberSides = Int32.Parse(sides);
            Console.WriteLine("Fantastic!  Now, let's see...");

            switch (numberSides)
            {
                case 1:
                    Console.WriteLine("Ahh yes, a bright point illuminating a field of darkness.  Anyway, we doin' shapes?");
                    break;
                case 2:
                    Console.WriteLine("You have found the quickest way from point A to point B.  Or, on side of a shape, but that's not quite enough.");
                    break;
                case 3:
                    Console.WriteLine("A triangle!  Yes, we like triangles.  What shall we do?");
                    string triangleMethod = Console.ReadLine();

                    switch (triangleMethod)
                    {
                        case Area:
                            Console.WriteLine("We will determine the area of your triangle.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Well, this quadrilateral could be a square.  Y/N?");
                    break;
                case 5:
                    Console.WriteLine("Pentagons really are underrated.  What shall we figure?");
                    break;
                case 6:
                    Console.WriteLine("Mmm, hexagons.  Reminds me of-  well, hexagons I suppose.");
                    break;
                case 7:
                    Console.WriteLine("The infamous seven-sided triangle!  Just kidding, we're looking at a septagon.  But why?");
                    break;
                case 8:
                    Console.WriteLine("Octagon and done it again!");
                    break;
                case 9:
                    Console.WriteLine("Nonagons makes me think it's a none-sided shape.  Anyway, shall we?");
                    break;
                case 0:
                    Console.WriteLine("Ahh, more than nine sides can be interesting.  Is it 10, 11, or 12 sided?");
                    break;
                default:
                    Console.WriteLine("Incorrect input.  Broken now - ");
                    break;
            }
        }
    }
}

