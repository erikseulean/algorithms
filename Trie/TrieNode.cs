using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieImplementation
{
    public class TrieNode
    {
        public char Value { get; set; }
        public TrieNode[] Childs { get; set; }

        public TrieNode()
        {
            Childs = new TrieNode[26];
        }
    }
}
