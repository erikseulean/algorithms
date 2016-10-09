using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Subsets
    {
        public List<List<int>> GetSubsets(List<int> list)
        {
            List<List<int>> final = new List<List<int>>();
            if (list.Count == 0)
            {
                final.Add(new List<int>());
                return final;
            }
            int head = list[0];
            List<int> tail = list.GetRange(1, list.Count - 1);
            foreach (var item in GetSubsets(tail))
            {
                List<int> s = new List<int>();
                s.Add(head);
                s.AddRange(item);
                final.Add(s);
                final.Add(item);
            }
            return final;
        }
    }
}
