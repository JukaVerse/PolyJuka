using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyJuka.Parser
{
    public class Parser
    {
        public static string Parse(string data)
        {
            return data.Split(" ").ToString();
        }
    }
}
