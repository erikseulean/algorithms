using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort
    {
        public void Sort(ref int[] array)
        {
            int min = int.MaxValue;
            int jPos;
            for (int i = 0; i < array.Length; i++)
            {
                jPos = i;
                min = array[i];
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < min)
                    {
                        min = array[j];
                        jPos = j;
                    }
                int aux = array[i];
                array[i] = min;
                array[jPos] = aux;
            }
        }
    }
}
