using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class DepthFirstSearch
    {
        private int nrNodes;
        private int[] visited;
        private int[,] matrix;
        public DepthFirstSearch(int nrNodes,int[,] matrix)
        {
            this.nrNodes = nrNodes;
            visited = new int[nrNodes];
            this.matrix = matrix;
        }

        public void DFS(int start)
        {
            visited[start] = 1;
            Console.Write(start + " ");
            for(int i=0;i<nrNodes;i++)
                if (matrix[i, start] == 1 && visited[i] == 0)
                    DFS(i); 
        }
    }
}
