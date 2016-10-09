using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthMorrisPrath
{
    class Program
    {
        static void Main(string[] args)
        {
            //KMPAgain kmp = new KMPAgain();
            //Console.WriteLine(kmp.FindMatch("abcxabcdabxabcdabcdabcy", "abcdabcy"));            
            KMP kmp = new KMP();
            Console.WriteLine(kmp.CheckExisting("abcxabcdabxabcdabcdabcy", "abcdabcy"));
            Console.ReadLine();
        }
    }
}
