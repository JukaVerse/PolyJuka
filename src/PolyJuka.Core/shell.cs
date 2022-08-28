using Spectre.Console;

namespace PolyJuka.Core
{
    public class PolyJuka
    {
        public static List<string> langData = new List<string>();
        public static List<string> parsedData = new List<string>();
        public class Shell
        {

            public static string NewLineBug(int line)
            {
                var res = string.Empty;
                var lineData = AnsiConsole.Prompt(
                     new TextPrompt<string>("[bold deeppink4]{" + line.ToString() + "}[/] [bold deeppink4]P[/][bold purple4]o[/][bold purple4_1]l[/][bold purple3]y[/] [bold blueviolet]>[/] ")
                    .PromptStyle("silver")
                    .AllowEmpty()
                    .ValidationErrorMessage("Parser Error.")
                    );
                res = lineData;
                if(lineData != "run();")
                {
                    Console.WriteLine("Not ran");
                    langData.Add(lineData);
                    foreach (var x in langData)
                    {
                        Console.Write(x);
                    }
                }
                if(lineData=="run();")
                {
                    List<string> ParsedLineLocal = new List<string>();
                    line = 0;
                    AnsiConsole.Write(new Rule("\n\n[green bold]Output[/]\n\n").LeftAligned().RoundedBorder().Border(border: BoxBorder.Double));
                    foreach(var x in langData)
                    {
                        ParsedLineLocal = x.Split(" ").ToList();
                        foreach(var y in ParsedLineLocal)
                        {
                            parsedData.Add(y);
                        }
                    }
                        Language.Lexer.lexer(parsedData);
                    
                }
                if (lineData == "exit();")
                {
                    AnsiConsole.Write(new Markup("[bold red]Terminating interactive shell...[/]"));
                    Environment.Exit(0);
                }
                return lineData;
            }
            public static void New()
            {
                AnsiConsole.Write(new Markup("\n[grey23 dim]PolyJuka interactive command shell - v0.0.001[/]" +
                    "\n[grey23 dim]You can use \"[/][grey23 underline bold]exit();" +
                    "[/][grey23 dim]\" to quit the proccess or \"[/]" +
                    "[grey23 underline bold]run();[/][grey23 dim]\" to execute[/]\n"));

                int line = 1;
                var lineData = NewLineBug(line);
                while (line != 0)
                {
                    if (lineData != "run();")
                    {
                        line++;
                        NewLineBug(line);
                    }
                }
            }
        }
    }
}
