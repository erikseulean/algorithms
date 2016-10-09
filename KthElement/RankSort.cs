using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthElement
{
    public class RankSort
    {
        //wrong!!
        //public int KthElement(int[] array, int left, int right, int k)
        //{
        //    if (left > right)
        //        return -1;
        //    int index = left + (right - left) / 2;
        //    int pivot = array[index];
        //    int i = left;
        //    int j = right;
        //    while (i < j)
        //    {
        //        while (array[i] < pivot) i++;
        //        while (array[j] > pivot) j--;

        //        if (i == index) index = j;
        //        else if (j == index) index = i;

        //        int aux = array[i];
        //        array[i] = array[j];
        //        array[j] = aux;
        //        i++;
        //        j--;
        //    }
        //    if (index > k) return KthElement(array, left, index, k);
        //    else if (k > index) return KthElement(array, index, right, k);
        //    else return array[k];
        //}

        public int KthElement(int[] array, int start, int end, int k)
        {
            int pivot = new Random().Next(start, end);
            int pivVal = array[pivot];

            //put it on the last pos
            array[pivot] = array[end];
            array[end] = pivVal;
            int location = start;
            for (int i = start; i < end; i++)
            {
                if(array[i] < array[end])
                {
                    int aux = array[i];
                    array[i] = array[location];
                    array[location] = aux;
                    location++;
                }
            }

            array[end] = array[location];
            array[location] = pivVal;

            if (k == location) return pivVal;
            if (k > location) return KthElement(array, location, end, k);
            else return KthElement(array, start, location, k);
        }
    }
}
