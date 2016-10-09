using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizationOfMaxDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5,1,9,1,3,7};
            Generalization dac = new Generalization();
            dac.DivideAndConquer(0, array.Length - 1, array);
        }
    }
}
