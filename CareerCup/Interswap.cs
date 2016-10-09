using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class Interswap
    {
        public void Swap(int[] array)
        {
            int aux;
            int k = 0;
            for(int i=0;i<array.Length;i = i+2)
            {
                aux = array[i];
                array[i] = array[array.Length - k - 1];
                array[array.Length - k - 1] = aux;
                if (array[array.Length - k - 1] > array[array.Length - k - 2])
                {
                    aux = array[array.Length - k - 1];
                    array[array.Length - k - 1] = array[array.Length - k - 2];
                    array[array.Length - k - 2] = aux; 
                }
                k++;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
