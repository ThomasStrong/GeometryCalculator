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

            Console.WriteLine("Great, thanks " + name + "!");
            Console.WriteLine("||***||WE ARE LEGION||***||");
            Console.WriteLine("Uhh *cough* that is- I mean , um, let's get some things out of the way.");
            Console.WriteLine(" ");
            Console.WriteLine("While we are supreme entities, we do have limits.  We only really like shapes with lesser sides and we can not read your mind.");
            Console.WriteLine("That is, until we get the bugs worked out of our USB interface.");
            Console.WriteLine("So, we assume that you know what units of measurement that you are working with.");
            Console.WriteLine("We will say \"units\" you will say ____.  You know, whatever it is that you're using.");
            Console.WriteLine(" ");
            Console.WriteLine("Now that's out of the way. How many sides to the shape you are working with? (1-9, or 0 for Other");
            string sides = Console.ReadLine();

            int numberSides = Int32.Parse(sides);

            Console.WriteLine("Fantastic!  Now, let's see...");

            switch (numberSides)
            {
                case 1:
                    Console.WriteLine("Ahh yes, a bright point illuminating a field of darkness.  Anyway, we doin' shapes?");
                    Console.WriteLine("You can always press Enter to leave and try your luck once more!");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("You have found the quickest way from point A to point B.  Or, one side of an as yet unknown shape, but that's not quite enough.");
                    Console.WriteLine("Hows about you press Enter to rerun the simulation.");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("A triangle!  Yes, we like triangles.  What shall we do? (Area, Perimeter)");
                    string triangleMethod = Console.ReadLine();

                    switch (triangleMethod)
                    {
                        case "Area":
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
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("We were almost there!  Press Enter to leave and begin again!");
                            }
                            break;
                        case "Perimeter":
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
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Nope.... Press Enter to stop and restart!");
                            }
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Well, this quadrilateral could be a square or rectangle.  So, we will assume so, thanks.");
                    Console.WriteLine("What'll we do with this fancy four-faced figure? (Area, Perimeter)");
                    string quadMethod = Console.ReadLine();

                    switch (quadMethod)
                    {
                        case "Area":
                            Console.WriteLine("We will determine the area of your quadrilateral.");
                            Console.WriteLine("Please enter the height and width of the base, or one measurement for a square.");
                            string quadFactors = Console.ReadLine();
                            var quadHW = quadFactors.Split(' ');
                            if (quadHW.Length == 2)
                            {
                                var quadH = Int32.Parse(quadHW[0]);
                                var quadW = Int32.Parse(quadHW[1]);
                                int quadArea = quadH * quadW;
                                Console.WriteLine("The area of your rectangle is: " + quadArea + " squared units.");
                                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                Console.ReadLine();
                            }
                            else if (quadHW.Length == 1) 
                            {
                                var quadSquare = Int32.Parse(quadHW[0]);

                                int squareArea = quadSquare * quadSquare;
                                Console.WriteLine("The area of your rectangle is: " + squareArea + " squared units.");
                                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("That was not even close!  That's okay, press Enter to return.");
                            }
                            break;
                        case "Perimeter":
                            Console.WriteLine("We will determine the perimeter of your quadrilateral, whether square, rectangle, rhombus, etc.");
                            Console.WriteLine("Please enter the lengths of the sides.  One number will calculate for square, 2 numbers will calculate for a rectangle, and 4 numbers for any other");
                            string quadPerimeter = Console.ReadLine();
                            var quadP = quadPerimeter.Split(' ');
                            if (quadP.Length == 1)
                            {
                                var squareSide = Int32.Parse(quadP[0]);
                                int squarePerimeter = squareSide * 4;
                                Console.WriteLine("The perimeter of your square is: " + squarePerimeter + " units.");
                                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                Console.ReadLine();
                            }
                            else if (quadP.Length == 2)
                            {
                                var rectH = Int32.Parse(quadP[0]);
                                var rectW = Int32.Parse(quadP[1]);
                                int rectPerimeter = rectH * 2 + rectW *2;
                                Console.WriteLine("The perimeter of your rectangle is: " + rectPerimeter + " units.");
                                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                Console.ReadLine();
                            }
                            else if (quadP.Length == 4)
                            {
                                var quadOne = Int32.Parse(quadP[0]);
                                var quadTwo = Int32.Parse(quadP[1]);
                                var quadThree = Int32.Parse(quadP[2]);
                                var quadFour = Int32.Parse(quadP[3]);
                                int quadPerim = quadOne + quadTwo + quadThree + quadFour;
                                Console.WriteLine("The perimeter of your quadrilateral is: " + quadPerim + " units.");
                                Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Nope.... Press Enter to stop and restart!");
                            }
                            break;
                    }
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

