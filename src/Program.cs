using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace PolyJuka.Runtime
{
    public class Runtime
    {
        public static void Main(String[] args)
        {
            if (args.Length == 0)
            {
                AnsiConsole.Write(
                    new FigletText("PolyJuka")
                    .LeftAligned().Color(Color.Purple));

                var Options = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("Select a option")
                    .PageSize(10)
                    .Mode(mode: SelectionMode.Independent)
                    .AddChoices(new[]
                    {
                    "[darkslategray2 bold]New PolyJuka Project[/]",
                    "[darkslategray2 bold]Run PolyJuka Project[/]",
                    "[darkslategray2 bold]Help[/]",
                    "[darkslategray2 bold]Support[/]",
                    "[darkslategray2 bold]Dictionary[/]"

                    }));

                if (Options == "[darkslategray2 bold]Support[/]")
                {
                    Process.Start("https://jukalang.com");
                }
                if (Options == "[darkslategray2 bold]New PolyJuka Project[/]")
                {

                }
                if (Options == "[darkslategray2 bold]Help[/]")
                {
                    var table = new Table().LeftAligned();

                    AnsiConsole.Live(table)
                        .Start(ctx =>
                        {
                            table.Border = TableBorder.Simple;
                            table.Collapse();
                            table.AddColumn("[skyblue1 bold]Command[/]");
                            ctx.Refresh();
                            Thread.Sleep(500);
                            table.AddColumn("[skyblue1 bold]Usage[/]");
                            ctx.Refresh();
                            Thread.Sleep(500);
                            table.AddColumn("[skyblue1 bold]Explanation[/]");
                            ctx.Refresh();
                            Thread.Sleep(500);
                            table.AddRow("[lightgreen_1 bold]Run[/]", "[orange1 bold]poly[/] [red1 bold]run[/] [underline green bold]<FILE>[/][seagreen3].pjka[/]", "[bold blue]Run's a PolyJuka file through the interperter[/]");
                            ctx.Refresh();
                            Thread.Sleep(200);
                            table.AddEmptyRow();
                            table.AddRow("[lightgreen_1 bold]Build[/]", "[orange1 bold]poly[/] [red1 bold]build[/] [underline green bold]<BUILD_CONFIG_FILE>[/] [italic yellow]-o <OUTPUT_DIRECTORY>[/]", "[bold blue]Build's your PolyJuka project[/]");
                            ctx.Refresh();
                            Thread.Sleep(200);
                            table.AddEmptyRow();
                            table.AddRow("[lightgreen_1 bold]Dictionary[/]", "[orange1 bold]poly[/] [red1 bold]dict[/] [underline green bold]<ERROR_CODE>[/]", "[bold blue]Gives you an explentation on a certain error[/]");
                            ctx.Refresh();
                            Thread.Sleep(200);
                            table.AddEmptyRow();
                            table.AddRow("[lightgreen_1 bold]Initalize[/]", "[orange1 bold]poly[/] [red1 bold]init[/]", "[bold blue]Auto generates a build file[/]");
                            ctx.Refresh();
                            Thread.Sleep(200);
                            table.AddEmptyRow();

                        });
                }
                if (Options == "[darkslategray2 bold]Dictionary[/]")
                {
                    var error_code = AnsiConsole.Ask<string>("What is your [red bold]Error Code[/]?");
                    AnsiConsole.Write(PolyJuka.Errors.ErrorDefinitons.ErrorLookup(error_code));
                    //AnsiConsole.Write(new Markup( PolyJuka.Errors.ErrorBuilder.Build(Errors.ErrorTypes.SYNTAX_ERROR, Errors.ErrorCodes.VTI, 1, 5, "main.pjka")));
                }
            }
            if (args[0] == "dict" && args.Length == 1)
            {
                var error_code = AnsiConsole.Ask<string>("What is your [red bold]Error Code[/]?");
                AnsiConsole.Write(PolyJuka.Errors.ErrorDefinitons.ErrorLookup(error_code));
            }
            if (args[0] == "help")
            {
                var table = new Table().LeftAligned();

                AnsiConsole.Live(table)
                    .Start(ctx =>
                    {
                        table.Border = TableBorder.Simple;
                        table.Collapse();
                        table.AddColumn("[skyblue1 bold]Command[/]");
                        ctx.Refresh();
                        Thread.Sleep(500);
                        table.AddColumn("[skyblue1 bold]Usage[/]");
                        ctx.Refresh();
                        Thread.Sleep(500);
                        table.AddColumn("[skyblue1 bold]Explanation[/]");
                        ctx.Refresh();
                        Thread.Sleep(500);
                        table.AddRow("[lightgreen_1 bold]Run[/]", "[orange1 bold]poly[/] [red1 bold]run[/] [underline green bold]<FILE>[/][seagreen3].pjka[/]", "[bold blue]Run's a PolyJuka file through the interperter[/]");
                        ctx.Refresh();
                        Thread.Sleep(200);
                        table.AddEmptyRow();
                        table.AddRow("[lightgreen_1 bold]Build[/]", "[orange1 bold]poly[/] [red1 bold]build[/] [underline green bold]<BUILD_CONFIG_FILE>[/] [italic yellow]-o <OUTPUT_DIRECTORY>[/]", "[bold blue]Build's your PolyJuka project[/]");
                        ctx.Refresh();
                        Thread.Sleep(200);
                        table.AddEmptyRow();
                        table.AddRow("[lightgreen_1 bold]Dict[/]", "[orange1 bold]poly[/] [red1 bold]dict[/] [underline green bold]<ERROR_CODE>[/]", "[bold blue]Gives you an explentation on a certain error[/]");
                        ctx.Refresh();
                        Thread.Sleep(200);
                        table.AddEmptyRow();
                        table.AddRow("[lightgreen_1 bold]Initalize[/]", "[orange1 bold]poly[/] [red1 bold]init[/]", "[bold blue]Auto generates a build file[/]");
                        ctx.Refresh();
                        Thread.Sleep(200);
                        table.AddEmptyRow();

                    });
            }
        }
    }
}