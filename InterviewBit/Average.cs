using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Average
    {
        public List<List<int>> getAvg(List<int> nr)
        {
            nr.Sort();
            int totalCount = 0;
            int avg = 0;
            for (int i = 0; i < nr.Count; i++)
                totalCount += nr[i];
            avg = totalCount / nr.Count;
            for (int i = 1; i < totalCount / avg; i++)
            {
                CheckExisting(i * avg, nr, i);
                if (list.Count == 0) continue;
                int total = 0;
                foreach (var myList in lists)
                {
                    list = myList;
                    List<int> other = new List<int>();
                    foreach (int item in nr)
                    {
                        if (!list.Contains(item))
                        {
                            other.Add(item);
                            total += item;
                        }
                    }
                    if (total % other.Count == 0 && total / other.Count == avg)
                    {
                        List<List<int>> finalList = new List<List<int>>();
                        finalList.Add(list);
                        finalList.Add(other);
                        return finalList;
                    }
                }
            }
            return new List<List<int>>();
        }

        private List<List<int>> lists = new List<List<int>>();
        private List<int> list = new List<int>();
        public void CheckExisting(int sum, List<int> nr, int numbers)
        {
            if (numbers == 0 && sum == 0)
            {
                if(lists.FirstOrDefault(s => s.SequenceEqual(list)) == null)
                    lists.Add(new List<int>(list));
                return;
            }
            
            for (int i = 0; i < nr.Count; i++)
            {
                if (list.Contains(nr[i])) continue;
                if (numbers == 1 && sum == nr[i])
                {
                    list.Add(nr[i]);
                    CheckExisting(0, nr, 0);
                    list.RemoveAt(list.Count - 1);
                    return;
                }
                else if (nr[i] < sum && numbers > 1)
                {
                    list.Add(nr[i]);
                    CheckExisting(sum - nr[i], nr, numbers - 1);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
