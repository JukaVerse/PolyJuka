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
            if (ERROR_CODE == "ERSIF")
            {
                string ERFND = "Error type: String type is invalid";
                string ERFND_EXAMPLE = "[teal]string[/] fiz = [red bold underline]False[/]";
                table = createPanel(ERROR_CODE, ERFND_EXAMPLE, ERFND);
            }
            if (ERROR_CODE == "ERVTI")
            {
                string ERFND = "Error type: Variable type invalid";
                string ERFND_EXAMPLE = "[bold red underline]SOME_VARIABLE_TYPE[/] fiz;";
                table = createPanel(ERROR_CODE, ERFND_EXAMPLE, ERFND);
            }
            if (ERROR_CODE == "ERCNC")
            {
                string ERFND = "Error type: Can not convert to type";
                string ERFND_EXAMPLE = "[teal bold]console[/].[aqua]out[/].[purple]print[/]([bold red underline]22[/]);";
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
