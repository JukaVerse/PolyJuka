using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyJuka.Language
{
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
                        Console.WriteLine("Setting " + dataArray[index] + " to " + dataArray[index+2]);
                    }
                }
            }
        }
    }
}
