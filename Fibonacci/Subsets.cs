using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Subsets
    {
        private List<int> set; 
        public Subsets()
        {
            set = new List<int>() { 1, 2, 3 };
        }

        public void PowerSets()
        {
            foreach (var item in PowerSets(set))
                PrintList(item);
        }

        public void PrintList(List<int> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public List<List<int>> PowerSets(List<int> original)
        {
            List<List<int>> list = new List<List<int>>();
            if (original.Count == 0)
            {
                list.Add(new List<int>());
                return list;
            }
            int head = original[0];
            List<int> tail = original.GetRange(1,original.Count-1);
            foreach (var item in PowerSets(tail))
            {
                List<int> newList = new List<int>();
                newList.Add(head);
                newList.AddRange(item);
                list.Add(item);
                list.Add(newList);
            }
            return list;
        }
    }
}
