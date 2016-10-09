using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearch
{
    public class GraphSearches
    {
        private LinkedList<int>[] list; 
        private int nrNodes;
        private int[] visited;
        public GraphSearches()
        {
            nrNodes = 8;
            visited = new int[nrNodes];
            list = new LinkedList<int>[nrNodes];
            list[1] = new LinkedList<int>();
            list[1].AddFirst(3);
            list[1].AddFirst(2);

            list[2] = new LinkedList<int>();
            list[2].AddFirst(7);
            list[2].AddFirst(1);

            list[3] = new LinkedList<int>();
            list[3].AddFirst(7);
            list[3].AddFirst(5);
            list[3].AddFirst(1);

            list[4] = new LinkedList<int>();
            list[4].AddFirst(6);

            list[5] = new LinkedList<int>();
            list[5].AddFirst(3);

            list[6] = new LinkedList<int>();
            list[6].AddFirst(4);

            list[7] = new LinkedList<int>();
            list[7].AddFirst(3);
            list[7].AddFirst(2);

        }

        public void bfsAllNodes()
        {
            for(int i=1;i<nrNodes;i++)
                if(visited[i] == 0)
                    bfs(i);
        }

        public void dfsAllNodes()
        {
            for (int i = 1; i < nrNodes; i++)
            {
                if(visited[i] == 0)
                    dfs(i);
            }
        }

        public void dfs(int start)
        {
            visited[start] = 1;
            Console.Write(start + " ");
            LinkedList<int> iterator = list[start];
            while (iterator.Count > 0)
            {
                if (visited[iterator.First.Value] == 0)
                {
                    dfs(iterator.First.Value);
                }
                iterator.RemoveFirst();
            }
        }
        
        //note to self: need to reset visit after doing one iteration


        public void bfs(int start)
        {
            
            visited[start] = 1;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int elem = queue.Dequeue();
                Console.Write(elem + " ");
                LinkedList<int> iterator = list[elem];
                while (iterator .Count != 0)
                {
                    if (visited[iterator.First.Value] == 0)
                    {
                        queue.Enqueue(iterator.First.Value);
                        visited[iterator.First.Value] = 1;
                    }
                    iterator.RemoveFirst();
                }
            }
        }
    }
}
