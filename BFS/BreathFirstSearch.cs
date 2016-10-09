using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class BreathFirstSearch
    {
        private int nrNodes;
        private int[] array;
        private Queue<int> queue;
        private int[,] matrix;
        public BreathFirstSearch(int nrNodes, int[,] matrix)
        {
            this.nrNodes = nrNodes;
            array = new int[nrNodes];
            this.matrix = matrix;
            queue = new Queue<int>(nrNodes);
        }
        public void BreathSearch(int startNode)
        {
            array[startNode-1] = 1;
            queue.Enqueue(startNode-1);
            while (queue.Count > 0)
            {
                int elem = queue.Dequeue();
                Console.Write((elem + 1) + " ");
                for(int i=1;i<=nrNodes;i++)
                    if (matrix[i-1, elem] == 1 && array[i-1] == 0)
                    {
                        queue.Enqueue(i-1);
                        array[i-1] = 1;
                    }
                    
            }         
        }

        public bool CheckRoute(int start, int end)
        {
            int[] visited = new int[nrNodes];
            visited[start] = 1;
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            while (q.Count > 0)
            {
                int elem = q.Dequeue();
                if (elem == end)
                    return true;
                for (int i = 0; i < nrNodes; i++)
                    if (matrix[elem, i] == 1 && visited[i] == 0)
                    {
                        visited[i] = 1;
                        q.Enqueue(i);
                    }
            }
            return false;
        }

        public int ShortestPath(int start, int end)
        {
            array[start] = 1;
            int[] path = new int[nrNodes];
            int[] road = new int[nrNodes];
            path[start] = 0;
            road[start] = -1;
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int elem = queue.Dequeue();
                for (int i = 0; i < nrNodes; i++)
                    if (matrix[i, elem] == 1 && array[i] == 0)
                    {
                        path[i] = path[elem] + 1;
                        road[i] = elem;
                        array[i] = 1;
                        queue.Enqueue(i);
                    }
            }

            
            Console.Write(end + " ");
            var first = road[end];
            for (int i = path[end]; i > 0; i--)
            {
                Console.Write(first + " ");
                first = road[first];
            }
            Console.WriteLine();

            return path[end];
        }	

        public void PrintOrder()
        {
            for(int i=0;i<nrNodes;i++)
                Console.Write(array[i] + " ");
        }
    }
}
