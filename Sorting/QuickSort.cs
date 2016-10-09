using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort
    {
        private int[] array;
        public QuickSort(int[] array)
        {
            this.array = array;
        }
        public void qSort(int left, int right)
        {
            int pivot = array[left + (right - left) / 2];
            int i = left;
            int j = right;
            int aux;
            while (i <= j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                    i++;
                    j--;
                }

            }
            if (i < right) qSort(i, right);
            if (j > left) qSort(left, j);
        }

        public void Print()
        {
            for(int i=0;i<array.Length;i++)
                Console.Write(array[i] + " ");
            Console.ReadLine();
        }
    }
}
