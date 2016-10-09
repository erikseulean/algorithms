using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class UndirectedGraph
    {
        public bool CheckPath(int[,] matrix, int nrNodes, int start, int end)
        {
            int[] visited = new int[nrNodes];
            int[] path = new int[nrNodes];
            path[start] = -1;
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            visited[start] = 1;
            while(q.Count > 0){
                int node = q.Dequeue();
                for(int i=0;i<nrNodes;i++)
                    if(matrix[node,i] == 1 && i == end){
                        path[i] = node;
                        matrix[i,node] = 0;
                        while(node != start){
                            matrix[node,path[node]] = 0;
                            node = path[node];
                        }
                        return true;
                    }
                    else if(matrix[node,i] == 1 && visited[i] == 0){
                        q.Enqueue(i);
                        path[i] = node;
                        visited[i] = 1;
                    }
            }
            return false;
        }

        public void TransformMatrix(int[,] matrix, int nrNodes)
        {
            for (int i = 1; i < nrNodes; i++)
                if (CheckPath(matrix,6,i,0) == false)
                    matrix[i, 0] = 1;
            PrintMatrix(matrix,nrNodes);
        }

        public void PrintMatrix(int[,] matrix, int nrNodes)
        {
            for (int i = 0; i < nrNodes; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < nrNodes; j++)
                    Console.Write(matrix[i, j] + " ");
            }
        }
    }
}
