using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class MatrixWord
    {
        private int[,] visited;

        public bool CheckMatrix(string word, char[,] matrix,int n, int m)
        {
            visited = new int[n, m];
            for(int i=0;i<n;i++)
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == word[0])
                    {
                        visited[i, j] = 1;
                        if (Back(word, matrix, i, j, 1,n,m)) return true;
                        visited[i, j] = 0;
                    }
                }
            return false;
        }

        public bool Back(string word, char[,] matrix, int startI, int startJ, int index, int n, int m)
        {
            if (index == word.Length)
                return true;
            for(int i=-1;i<2;i++)
                for (int j = -1; j < 2; j++)
                {
                    int nexti = startI + i;
                    int nextj = startJ+j;
                    if (CanGo(nexti, nextj, n, m) && visited[nexti, nextj] == 0 && word[index] == matrix[nexti, nextj])
                    {
                        visited[nexti, nextj] = 1;
                        if (Back(word, matrix, nexti, nextj,index+1, n, m) == true) return true;
                    }
                }
            visited[startI, startJ] = 0;
            return false;
        }

        public bool CanGo(int i, int j, int n, int m)
        {
            if (i < n && j < m && i>-1 && j > -1)
                return true;
            return false;
        }
    }
}
