using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch
{
    public class RecursiveList
    {
        private Dictionary<int, List<int>> numbers;

        public void Print()
        {
            numbers = new Dictionary<int, List<int>>();
            numbers.Add(1, null);
            numbers.Add(2, new List<int>() { 1 });
            numbers.Add(3, new List<int>() { 2, 1 });
            numbers.Add(4, new List<int>() { 3, 2 });
          

            Store(4, numbers);
        }
        private List<List<int>> nrs = new List<List<int>>();
        private List<int> numb = new List<int>();
        public void Store(int node, Dictionary<int, List<int>> nodes)
        {
            if (node == 1) return;
            for (int i = 0; i < nodes[node].Count; i++)
            {
                Store(nodes[node][i], nodes);
                numb.Add(nodes[node][i]);
                if (node == 4)
                {
                    numb.Add(node);
                    for (int j = 0; j < numb.Count; j++)
                        Console.Write(numb[j] + " ");
                    numb = new List<int>();
                    Console.WriteLine();
                }
                
            }
        }
    }
}
