using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace Geometry_Calculator
{
    class MainIntro
    {
        public static void UserIntro()
        {
            Console.WriteLine("Welcome to the Awesome, Amazing, Alliterative Geometry Calculator!");
            Console.WriteLine("We are here to provide the best in geometric calculations!  Stand by for awesomeness...");

            Console.WriteLine("While we are waiting, may I get your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Great, thanks " + name + "!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("||***||WE ARE LEGION||***||");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Uhh *cough* that is- I mean , um, let's get some things out of the way.");
            Console.WriteLine(" ");
            Console.WriteLine("While we are supreme entities, we do have limits.  We only really like shapes with lesser sides and we can not read your mind.");
            Console.WriteLine("That is, until we get the bugs worked out of our USB interface.");
            Console.WriteLine("So, we assume that you know what units of measurement that you are working with.");
            Console.WriteLine("At this time we also assume anything larger than a quadrilateral is a regular polygon.");
            Console.WriteLine("We will say \"units\" you will say ____.  You know, whatever it is that you're using.");
            Console.WriteLine(" ");
            Console.WriteLine("Also, if you are done after a calculation, type 'Exit' to leave the program.  Now that's out of the way.");
        }

        public static string UserSelection(string[] options)
        {            
            return AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("How many [green]sides[/] to the shape you are working with? [yellow](1-9, or 0 for Other)[/]")
                .PageSize(10)
                .AddChoices(options));
        }
    }
}
