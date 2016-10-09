using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SortString
{
    public class QuickSort
    {
        public char[] Word;

        public QuickSort(char[] word)
        {
            Word = word;
        }

        public void Sort(int left, int right)
        {
            int pivot = Word[left + (right - left)/2];
            int i = left;
            int j = right;
            char aux;
            while (i <= j)
            {
                while (Word[i] < pivot) i++;
                while (Word[j] > pivot) j--;

                aux = Word[i];
                Word[i] = Word[j];
                Word[j] = aux;
                i++;
                j--;

            }
            if(i<right) Sort(i,right);
            if(j > left) Sort(left,j);
        }
    }
}
