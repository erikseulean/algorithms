using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class AndroidLockPaths
    {
        int counter = 0;
        int[] visited;
        List<int> paths;
        public AndroidLockPaths()
        {
            Reset();
        }
        public void Reset()
        {
            int counter = 0;
            visited = new int[9];
            paths = new List<int>();
            visited[0] = 1;
            paths.Add(0);
        }

        public void ComputePaths(int[,] matrix, int start, int nodes)
        {
            ValidPath(nodes);
            for(int i=0;i<9;i++)
                if (visited[i] == 0 && matrix[start, i] == 1)
                {
                    paths.Add(i);
                    visited[i] = 1;
                    ComputePaths(matrix, i, nodes + 1);
                    paths.Remove(i);
                    visited[i] = 0;
                }
        }

        public void ValidPath(int nodes)
        {
            int countPaths = 0;
            int p;
            if (nodes > 8)
            {
                counter++;
                foreach(var item in paths)
                   Console.Write(item + " ");
                Console.WriteLine();
            }
        }
    }
}
