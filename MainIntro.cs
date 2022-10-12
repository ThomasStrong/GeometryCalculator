using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spectre.Console;

namespace Geometry_Calculator
{
    class MainIntro
    {
        public static void UserIntro()
        {
            AnsiConsole.Markup("<^^^^^^^^^^^^^^^^^^[cornflowerblue]^^^^^^^^^^^[/][gold3]^^^^^^^^^[/][darkred]^^^^^^^^^^^^^^^^[/]^^^^^^^^^^^^^^^^^^^^^^^^>\n");
            AnsiConsole.Markup("<*******************[cornflowerblue]**********[/][gold3]*********[/][darkred]***************[/]*************************>\n");
            AnsiConsole.Markup("<*  [yellow]*[/][blue]*[/][red]*[/]Welcome to the [blue]Awesome[/]  [yellow]Amazing[/]  [red]Alliterative[/] Geometry Calculator![red]*[/][blue]*[/][yellow]*[/]  *>\n");
            AnsiConsole.Markup("<*******************[cornflowerblue]**********[/][gold3]*********[/][darkred]***************[/]*************************>\n");
            AnsiConsole.Markup("<vvvvvvvvvvvvvvvvvv[cornflowerblue]vvvvvvvvvvv[/][gold3]vvvvvvvvv[/][darkred]vvvvvvvvvvvvvvvv[/]vvvvvvvvvvvvvvvvvvvvvvvv>\n");
            Console.WriteLine(" ");
            AnsiConsole.Markup("We are");
            Thread.Sleep(100);
            AnsiConsole.Markup(" here to ");
            Thread.Sleep(100);
            AnsiConsole.Markup("provide the");
            Thread.Sleep(100);
            AnsiConsole.Markup(" best in ");
            Thread.Sleep(100);
            AnsiConsole.Markup("geometric calculations!\n");
            Thread.Sleep(100);
            AnsiConsole.Markup("  Stand by for awesomeness...\n");
            Thread.Sleep(800);
            AnsiConsole.Markup("While we are waiting, may I get [green]your name[/]? ");
            string name = Console.ReadLine();

            Console.WriteLine(" ");
            AnsiConsole.Markup($"Great, thanks [red on yellow]{name}[/]!\n");
            Console.WriteLine(" ");

            for (int i = 0; i < 20; i++)
            {
                AnsiConsole.Markup("[yellow on maroon]||***||WE ARE LEGION||***|| [/]\n");
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("Uhh *cough* that is- I mean- um let's get some things out of the way.");
            Console.WriteLine(" ");
            Thread.Sleep(500);
            Console.WriteLine("While we are supreme entities, we do have limits.  We can not read your mind.");
            Console.WriteLine("That is, until we get the bugs worked out of our USB interface.");
            Thread.Sleep(500);
            Console.WriteLine("So, we assume that you know what units of measurement that you are working with.");
            Console.WriteLine("We will say \"units\" you will say ____.  You know, whatever it is that you're using.");
            Thread.Sleep(500);
            AnsiConsole.Markup("At this time we also assume anything larger than a quadrilateral is a [red]regular polygon[/].\n");
            Console.WriteLine(" ");
            Console.WriteLine("Press [Enter] so that I know you read all of that.");
            Console.ReadLine();
        }

        public static string UserMenu(string title, string[] options)
        {            
            return AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title(title)
                .PageSize(10)
                .AddChoices(options));
        }
    }
}
