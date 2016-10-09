using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class GenerateNumbers
    {
        private int[] array;
        public GenerateNumbers()
        {
            Random r = new Random();
            array = new int[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(1000);
        }

        public void RandomNumbers(int m)
        {
            Random r = new Random();
            if (m > array.Length)
                return;
            for (int i = 0; i < m; i++)
            {
                int index = r.Next(array.Length - i - 1);
                Console.Write(array[index] + " ");
                int aux = array[index];
                array[index] = array[array.Length - i - 1];
                array[array.Length - i - 1] = aux;
            }
        }
    }
}
