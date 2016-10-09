using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumModK
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            var list = c.GetSum(new int[] { 429, 334, 62, 711, 704, 763, 98, 733, 721, 995 });
        }
    }
}
