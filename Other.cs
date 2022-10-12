using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Other
    {
        public string Method { get; set; }
        public static string OtherOptionsMenu()
        {
            string otherOptionsTitle = "Ahh, more than nine sides can be interesting.  Is it 10, 11, or 12-sided?";
            string[] otherOptions =
            {
                "10", "11", "12"
            };

            string otherMethods = MainIntro.UserMenu(otherOptionsTitle, otherOptions);
            return otherMethods;
        }


        public static void OtherMethodHandler(string otherMethods)
        {

            switch (otherMethods)
            {
                case "10":
                    Console.WriteLine("The majestic decagon!  That is a big one.");
                    Console.WriteLine("At this time I can only tell you very little stuff.  Like its name.  Goodbye!");
                    break;
                case "11":
                    Console.WriteLine("This is a hendecagon.  No chickens here, though.");
                    Console.WriteLine("For another little nugget press Enter to leave and try another one!");
                    break;
                case "12":
                    Console.WriteLine("The dirty-dozen-sided dodecagon, eh?  Some call them duodecagons, but I'm not one of them.");
                    Console.WriteLine("Press enter for a baker's dozen!  That's the extent of my knowledge.");
                    break;
            }
        }
    }
}
