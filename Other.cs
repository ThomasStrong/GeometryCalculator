using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class Other
    {
        public static string OtherOptionsMenu()
        {
            string otherOptionsTitle = "Ahh, more than nine sides can be interesting.  Is it 10, 11, or 12-sided?";
            string[] otherOptions =
            {
                "10", "11", "12", "Exit"
            };

            string otherMethods = MainIntro.UserMenu(otherOptionsTitle, otherOptions);
            return otherMethods;
        }


        public static void OtherMethodHandler(string otherMethods, ExitConditional exitCondition)
        {
            switch (otherMethods)
            {
                case "10":
                    Console.WriteLine(" ");
                    AnsiConsole.Markup("The majestic [yellow]decagon[/]!  That is a big one.");
                    Console.WriteLine("At this time I can only tell you very little stuff.  Like its name.  Goodbye!");
                    Console.WriteLine(" ");
                    break;
                case "11":
                    Console.WriteLine(" ");
                    AnsiConsole.Markup("This is a [yellow]hendecagon[/].  No chickens here, though.");
                    Console.WriteLine("For another little nugget press Enter to leave and try another one!");
                    Console.WriteLine(" ");
                    break;
                case "12":
                    Console.WriteLine(" ");
                    AnsiConsole.Markup("The dirty-dozen-sided [yellow]dodecagon[/], eh?  Some call them duodecagons, but I'm not one of them.");
                    Console.WriteLine("Press enter for a baker's dozen!  That's the extent of my knowledge.");
                    Console.WriteLine(" ");
                    break;
                case "Exit":
                    exitCondition.ToExit = true;
                    break;
            }
        }
    }
}
