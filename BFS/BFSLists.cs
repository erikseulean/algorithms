using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class BFSLists
    {
        private List<int>[] list;
        public BFSLists()
        {
            list = new List<int>[7];
            list[0] = new List<int>() { 1, 3, 4 };
            list[1] = new List<int>() { 0 };
            list[2] = new List<int>() { 4, 5 };
            list[3] = new List<int>() { 0, 5 };
            list[4] = new List<int>() { 0, 2, 6};
            list[5] = new List<int>() { 2, 3 };
            list[6] = new List<int>() { 5 };
        }

        public void BFS(int start)
        {
            int[] visited = new int[7];
            visited[start] = 1;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                Console.Write(node + " ");
                for (int i = 0; i < list[node].Count; i++)
                {
                    if (visited[list[node][i]] == 0)
                    {
                        queue.Enqueue(list[node][i]);
                        visited[list[node][i]] = 1;
                    }
                }
            }
        }
        private int[] visited = new int[7];
        public void DFS(int start)
        {
            visited[start] = 1;
            Console.Write(start + " ");
            for(int i=0;i<list[start].Count;i++)
                if(visited[list[start][i]] == 0)
                {
                    DFS(list[start][i]);
                }
        }
    }
}
