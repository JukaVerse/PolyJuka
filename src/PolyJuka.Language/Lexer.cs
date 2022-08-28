using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spectre.Console;
namespace PolyJuka.Language
{
    public enum VariableType
    {
        INTEGER,
        FLOAT,
        DOUBLE,
        BOOL,
        STRING,
        CHAR,
        NULL

    }
    public class Lexer
    {
        public static bool checkForToken(string node, string tokenName)
        {
            bool res = false;
            if (node == tokenName)
            {
                res = true;
            }
            return res;
        }
        public static VariableType ValuateType(string data)
        {
            VariableType type = VariableType.NULL;
            char[] parsedData = data.ToCharArray();
            int n;
            bool isNumberic = int.TryParse(data, out n);
            if(data == "NULL")
            {
                type = VariableType.NULL;
            }
            if (parsedData[0].ToString() == "\"")
            {
                type = VariableType.STRING;
            }
            if (parsedData[parsedData.Length-1].ToString() == "f")
            {
                type = VariableType.FLOAT;
            }
            if (data == "True" || data == "False")
            {
                type = VariableType.BOOL;
            }
            if (isNumberic)
            {
                type = VariableType.INTEGER;
            }
            if (parsedData[0].ToString() == "'" && parsedData[1].ToString().Length == 1 && parsedData[2].ToString() == "'")
            {
                type = VariableType.CHAR;
            }
            return type;
        }

        public static void lexer(List<string> dataArray)
        {

            int index = 0;
            foreach (string node in dataArray)
            {
                index++;
                if (!string.IsNullOrWhiteSpace(node))
                {
                    if(checkForToken(node, "set"))
                    {
                        if (dataArray[index+1] != "=")
                        {
                            AnsiConsole.Write(new Markup(Errors.ErrorBuilder.Build(Errors.ErrorTypes.SYNTAX_ERROR, Errors.ErrorCodes.IVA , 0, 0, "JukaInteractiveShell")));
                            Environment.Exit(1);
                        }
                        VariableType type = ValuateType(dataArray[index + 2]);
                        if(type == VariableType.STRING)
                        {

                        }
                        Console.WriteLine("Setting " + dataArray[index] + " to " + dataArray[index+2] + " type: " + ValuateType(dataArray[index+2]));
                        MemoryStream memStream = new MemoryStream();
                        // memStream.Write(dataArray[index + 2].ToArray<byte>(), 0, dataArray[index + 2].Length);
                    }
                    if(checkForToken(node, "writef"))
                    {
                        if (dataArray[index] != ">>")
                        {
                            if(dataArray[index+1] != " ")
                            {
                                index++;
                            }
                            AnsiConsole.Write(new Markup(Errors.ErrorBuilder.Build(Errors.ErrorTypes.SYNTAX_ERROR, Errors.ErrorCodes.SIF, 0, 0, "JukaInteractiveShell")));
                        }
                        else
                        {
                            int startPoint = index + 1;
                            int endPoint = dataArray.IndexOf("<<")-1;
                            string res = String.Empty;
                            for(int i = startPoint; i <= endPoint; i++)
                            {
                                res = res + (dataArray[i].ToString()) +" ";
                            }
                            AnsiConsole.Write(new Markup(res));
                        }
                    }
                    if (checkForToken(node, "write"))
                    {
                        if (dataArray[index] != ">>")
                        {
                            if (dataArray[index + 1] != " ")
                            {
                                index++;
                            }
                            AnsiConsole.Write(new Markup(Errors.ErrorBuilder.Build(Errors.ErrorTypes.SYNTAX_ERROR, Errors.ErrorCodes.SIF, 0, 0, "JukaInteractiveShell")));
                        }
                        else
                        {
                            int startPoint = index + 1;
                            int endPoint = dataArray.IndexOf("<<") - 1;
                            string res = String.Empty;
                            for (int i = startPoint; i <= endPoint; i++)
                            {
                                res = res + (dataArray[i].ToString()) + " ";
                            }
                            Console.Write(res);
                        }
                    }
                    if (checkForToken(node, "writeLine"))
                    {
                        if (dataArray[index] != ">>")
                        {
                            if (dataArray[index + 1] != " ")
                            {
                                index++;
                            }
                            AnsiConsole.Write(new Markup(Errors.ErrorBuilder.Build(Errors.ErrorTypes.SYNTAX_ERROR, Errors.ErrorCodes.SIF, 0, 0, "JukaInteractiveShell")));
                        }
                        else
                        {
                            int startPoint = index + 1;
                            int endPoint = dataArray.IndexOf("<<") - 1;
                            string res = String.Empty;
                            for (int i = startPoint; i <= endPoint; i++)
                            {
                                res = res + (dataArray[i].ToString()) + " ";
                            }
                            Console.WriteLine(res);
                        }
                    }
                    if (checkForToken(node, "figlet"))
                    {
                        if (dataArray[index] != ">>")
                        {
                            AnsiConsole.Write(new Markup(Errors.ErrorBuilder.Build(Errors.ErrorTypes.SYNTAX_ERROR, Errors.ErrorCodes.IVA, 0, 0, "JukaInteractiveShell")));
                        }
                        else
                        {
                            int startPoint = index + 1;
                            int endPoint = dataArray.IndexOf("<<") - 1;
                            string res = String.Empty;
                            for (int i = startPoint; i <= endPoint; i++)
                            {
                                res = res + (dataArray[i].ToString()) + " ";
                            }
                            AnsiConsole.Write(new FigletText(res).ToString());
                        }
                    }
                }
            }
        }
    }
}
