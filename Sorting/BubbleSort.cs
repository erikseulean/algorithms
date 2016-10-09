using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort
    {
        public void Sort(ref int[] array)
        {
            for(int i=0;i<array.Length;i++)
                for(int j=i+1;j<array.Length;j++)
                    if (array[i] > array[j])
                    {
                        var aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
        }


    }
}
