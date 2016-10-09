using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie t = new Trie();
            t.Insert("car");
            t.Insert("bartender");
            t.Insert("bar");
            t.Insert("bank");
            Console.WriteLine(t.Find("baris"));
            Console.WriteLine(t.Find("bank"));
            Console.WriteLine(t.Find("bartender"));
            Console.ReadLine();
        }
    }
}
