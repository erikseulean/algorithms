using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Cmmmc cmmmc = new Cmmmc();
            Console.WriteLine(cmmmc.GetCmmmc(4,8));
            Console.ReadLine();
        }
    }
}
