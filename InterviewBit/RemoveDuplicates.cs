using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class RemoveDuplicates
    {
        public int NrDuplicates(List<int> array, int nr)
        {
            int i = 0;
            int j = array.Count - 1;
            while (j > i)
            {
                if (array[i] != nr) i++;
                else
                {
                    while (j > i && array[j] == nr) j--;
                    if (j > i)
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                    i++;
                }
            }
            array.RemoveRange(i, array.Count - i);
            return array.Count;
        }
    }
}
