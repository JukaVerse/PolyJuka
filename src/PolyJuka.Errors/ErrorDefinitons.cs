using Spectre.Console;

namespace PolyJuka.Errors
{
    public class ErrorDefinitons
    {
        public static Table ErrorLookup(string ERROR_CODE)
        {
            Table table = new Table();
            if (ERROR_CODE == "ERFND")
            {
                string ERFND = "Error type: Function undefined";
                string ERFND_EXAMPLE = "[fuchsia]fx [/][skyblue2]SomeFunction[/]() {\n   [red3]ret[/][skyblue2]1+1[/];\n}\n[underline red]SomeOtherFunction();[/]";
                table = createPanel(ERROR_CODE, ERFND_EXAMPLE, ERFND);
            }
            return table;
        }
        public static Table createPanel(string ERROR_CODE, string ERROR_EXAMPLE, string ERROR_DEFINITION)
        {
            var table = new Table();

            table.AddColumn("Error");
            table.AddColumn("Example");
            table.AddColumn("Description");
            table.AddRow(new Markup("[red bold]" + ERROR_CODE + "[/]"), new Markup( ERROR_EXAMPLE ), new Markup( ERROR_DEFINITION));
            return table;

        }
    }
}
