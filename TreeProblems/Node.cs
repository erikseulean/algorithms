using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProblems
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Nodes { get; set; }

        public Node()
        {
            Nodes = new List<Node>();
        }
    }
}
