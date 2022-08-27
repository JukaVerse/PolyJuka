using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyJuka.Errors
{
    /*
     * Error Format:
     * 
     * [Error Type]: ER[ERROR_CODE] [LINE]:[COLUMN] - [FILE]
     * 
     */
    public class ErrorBuilder
    {
        public static string Build(ErrorTypes type, ErrorCodes errorCode, int line, int column, string file)
        {
            string res = "[yellow bold]PolyJuka " + type.ToString() + ":[/]\n   [dim]ER" + errorCode.ToString() + "[/][blue dim] " + line.ToString() + ":" + column.ToString() + "[/] - [underline]" + file + "[/]";
            return res;
        }
        
    }
}
