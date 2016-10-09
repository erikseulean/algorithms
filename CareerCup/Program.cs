using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    class Program
    {
        static void Main(string[] args)
        {
            LCS lcs = new LCS();
            lcs.ComputeSequence("324519723841", "1032450723014");
            Console.ReadLine();

        }
    }
}
