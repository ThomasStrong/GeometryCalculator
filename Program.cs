using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            if (counter == 0)
            {
                MainIntro.UserIntro();
                counter++;
            }

            string line;
            do
            {
                if (counter != 1)
                {
                    Console.WriteLine("Press Enter to continue, or type 'Exit' to close this amazing program.");
                    line = Console.ReadLine();
                }

                Console.WriteLine("How many sides to the shape you are working with? (1-9, or 0 for Other)");
                string sides = Console.ReadLine();
                int numberSides = Int32.Parse(sides);
                Console.WriteLine("Fantastic!  Now, let's see...");

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
                        Triangle triangle = new Triangle();
                        Triangle.Intro();
                        triangle.TriangleMethod = Console.ReadLine();
                        Triangle.TriangleMethodHandler(triangle.TriangleMethod);
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
                                }
                                else if (quadHW.Length == 1)
                                {
                                    var quadSquare = Int32.Parse(quadHW[0]);

                                    int squareArea = quadSquare * quadSquare;
                                    Console.WriteLine("The area of your rectangle is: " + squareArea + " squared units.");
                                    Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
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
                                }
                                else if (quadP.Length == 2)
                                {
                                    var rectH = Int32.Parse(quadP[0]);
                                    var rectW = Int32.Parse(quadP[1]);
                                    int rectPerimeter = rectH * 2 + rectW * 2;
                                    Console.WriteLine("The perimeter of your rectangle is: " + rectPerimeter + " units.");
                                    Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
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
                                }
                                else
                                {
                                    Console.WriteLine("Nope.... Press Enter to stop and restart!");
                                }
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Pentagons really are underrated.  What shall we figure? (Area, Perimeter)");
                        string pentaMethod = Console.ReadLine();

                        switch (pentaMethod)
                        {
                            case "Area":
                                Console.WriteLine("We will determine the area of your pentagon.");
                                Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
                                break;
                            case "Perimeter":
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
                                break;
                        }
                        break;
                    /*  Console.WriteLine("");   <<<< Template*/
                    case 6:
                        Console.WriteLine("Mmm, hexagons.  Reminds me of-  well, hexagons I suppose.");
                        Console.WriteLine("I can think of a few things to do with a hexagon.... You?  (Area, Perimeter)");
                        string hexMethod = Console.ReadLine();

                        switch (hexMethod)
                        {
                            case "Area":
                                Console.WriteLine("We should determine the area of your hexagon.");
                                Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
                                break;
                            case "Perimeter":
                                Console.WriteLine("We will determine the perimeter of your Hexagon.");
                                Console.WriteLine("Please enter the lengths of the sides.");
                                string hexSides = Console.ReadLine();
                                var hexP = hexSides.Split(' ');
                                if (hexP.Length == 6)
                                {
                                    var hexX = Int32.Parse(hexP[0]);
                                    var hexY = Int32.Parse(hexP[1]);
                                    var hexZ = Int32.Parse(hexP[2]);
                                    var hexA = Int32.Parse(hexP[3]);
                                    var hexB = Int32.Parse(hexP[4]);
                                    var hexC = Int32.Parse(hexP[5]);
                                    int hexPerimeter = hexX + hexY + hexZ + hexA + hexB + hexC;
                                    Console.WriteLine("The perimeter of your hexagon is: " + hexPerimeter + " units.");
                                    Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                }
                                else
                                {
                                    Console.WriteLine("Close, but no cigar!  Need lengths for 6 sides.  Press Enter to leave.");
                                }
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine("The infamous seven-sided triangle!  Just kidding, we're looking at a septagon.  But why?");
                        Console.WriteLine("Don't see many of these.  Need?  (Area, Perimeter)");
                        string septMethod = Console.ReadLine();

                        switch (septMethod)
                        {
                            case "Area":
                                Console.WriteLine("We should determine the area of your septagon.");
                                Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
                                break;
                            case "Perimeter":
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
                                break;
                        }
                        break;
                    case 8:
                        Console.WriteLine("Octagon and done it again!");
                        Console.WriteLine("What are we doing with this eight-sided polygon? (Area, Perimeter)");
                        string octMethod = Console.ReadLine();

                        switch (octMethod)
                        {
                            case "Area":
                                Console.WriteLine("We should determine the area of your octagon.");
                                Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
                                break;
                            case "Perimeter":
                                Console.WriteLine("We will determine the perimeter of your Octagon.");
                                Console.WriteLine("Please enter the lengths of the sides.");
                                string octSides = Console.ReadLine();
                                var octP = octSides.Split(' ');
                                if (octP.Length == 8)
                                {
                                    var octX = Int32.Parse(octP[0]);
                                    var octY = Int32.Parse(octP[1]);
                                    var octZ = Int32.Parse(octP[2]);
                                    var octA = Int32.Parse(octP[3]);
                                    var octB = Int32.Parse(octP[4]);
                                    var octC = Int32.Parse(octP[5]);
                                    var octD = Int32.Parse(octP[6]);
                                    var octE = Int32.Parse(octP[7]);
                                    int octPerimeter = octX + octY + octZ + octA + octB + octC + octD + octE;
                                    Console.WriteLine("The perimeter of your octagon is: " + octPerimeter + " units.");
                                    Console.WriteLine("That'll do.  Press Enter to leave and begin again!");
                                }
                                else
                                {
                                    Console.WriteLine("That was almost the number of numbers I was hoping to enumerate.  Press Enter to leave.");
                                }
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Nonagons (also enneagons) makes me think it's a none-sided shape.  Anyway, shall we?");
                        Console.WriteLine("I think we can do something with you nonagon! (Area, Perimeter)");
                        string nonMethod = Console.ReadLine();

                        switch (nonMethod)
                        {
                            case "Area":
                                Console.WriteLine("We should determine the area of your nonagon.");
                                Console.WriteLine("Just kidding!  My architect has not given me this power yet.  Press Enter to leave foul suggestions in their inbox.");
                                Console.ReadLine();
                                break;
                            case "Perimeter":
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
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Ahh, more than nine sides can be interesting.  Is it 10, 11, or 12 sided?");
                        string extraShapes = Console.ReadLine();
                        int largeShapes = Int32.Parse(extraShapes);
                        switch (largeShapes)
                        {
                            case 10:
                                Console.WriteLine("The majestic decagon!  That is a big one.");
                                Console.WriteLine("At this time I can only tell you very little stuff.  Like its name.  Goddbye!");
                                break;
                            case 11:
                                Console.WriteLine("This is a hendecagon.  No chickens here, though.");
                                Console.WriteLine("For another little nugget press Enter to leave and try another one!");
                                break;
                            case 12:
                                Console.WriteLine("The dirty-dozen-sided dodecagon, eh?  Some call them duodecagons, but I'm not one of them.");
                                Console.WriteLine("Press enter for a baker's dozen!  That's the extent of my knowledge.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect input.  Broken now - ");
                        break;
                }
            } while ((line = Console.ReadLine()) != "Exit");
        }
    }
}

