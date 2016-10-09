using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    public class Permute
    {
        public bool permuteArray(int[] array)
        {
            int i = array.Length - 2;
            while (i > -1 && array[i] > array[i + 1])
                i--;
            if (i == -1) return false;
            int j = array.Length - 1;
            while (j > i && array[j] < array[i])
                j--;
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;

            int k = i + 1;
            int p = array.Length - 1;
            while (k < p)
            {
                aux = array[k];
                array[k] = array[p];
                array[p] = aux;
                k++;
                p--;
            }
            return true;
        }

        public void PrintPermutations(int[] array)
        {
            while (permuteArray(array))
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
