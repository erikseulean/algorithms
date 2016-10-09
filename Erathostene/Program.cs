using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erathostene
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];

            for (int i = 2; i < 1000; i++)
            {
                if (array[i] == 0)
                    for (int j = i* i ; j < 1000; j += i)
                        array[j] = 1;
            }
            for (int i = 0; i < array.Length; i++)
                if (array[i] == 0)
                    Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
