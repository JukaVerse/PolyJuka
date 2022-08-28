using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyJuka.Syntax.Node
{
    public enum NodeType
    {
        WRITE,
        WRITELINE,
        SET
    }
    public class Node
    {
        public NodeType type { get; set; }
        public string NodeValue { get; set; }
    }
}
