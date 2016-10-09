using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class SumArray
    {
        private List<List<int>> sumArray = new List<List<int>>();
        private List<int> partial = new List<int>();
        public List<List<int>> GetSums(List<int> numbers, int sum)
        {
            Back(numbers, sum,0);
            return sumArray;
        }

        public void Back(List<int> array, int sum,int start)
        {
            for (int i = start; i < array.Count; i++)
            {
                partial.Add(array[i]);
                int curr = CheckSum();
                if (curr < sum)
                {
                    Back(array, sum, i + 1);
                }
                else if (curr == sum)
                    TryAdd();
                partial.RemoveAt(partial.Count - 1);
            }
            //partial.RemoveAt(partial.Count - 1);
        }

        public int CheckSum()
        {
            int sum = 0;
            for (int i = 0; i < partial.Count; i++)
                sum += partial[i];
            return sum;
        }

        public void TryAdd()
        {
            List<int> list = new List<int>(partial);
            list.Sort();
            if (!sumArray.Contains(list))
                sumArray.Add(list);
        }
    }
}
