using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class LCS
    {
        private int[,] matrix;
        private char[,] path;

        public void ComputeSequence(string s1, string s2)
        {
            matrix = new int[s1.Length+1, s2.Length+1];
            path = new char[s1.Length+1, s2.Length+1];
            for(int i=1;i<=s1.Length;i++)
                for (int j = 1; j <=s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                        path[i, j] = '0';
                    }
                    else if (matrix[i - 1, j] > matrix[i, j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j];
                        path[i, j] = '1';
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j - 1];
                        path[i, j] = '2';
                    }
                }
            Print(s1.Length, s2.Length,s1);
        }

        public void Print(int n, int m, string s)
        {
            Console.WriteLine("Length" + matrix[n, m]);

            for (int i = 0; i <= n; i++) { 
                Console.WriteLine();
                for (int j = 0; j <= m; j++)
                    Console.Write(matrix[i, j] + " ");
                }
            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= m; j++)
                    Console.Write(path[i, j] + " ");
            }
            Console.WriteLine();

            CheckConsecutivePath(n, m, s);
            }

        public void CheckPath(int n, int m,string s1)
        {
            if (matrix[n,m]==0)
                return;
            if (path[n, m] == '0')
            {
                CheckPath(n - 1, m - 1,s1);
                Console.Write(s1[n-1] + " ");
            }
            else if (path[n, m] == '1') CheckPath(n-1, m,s1);
            else CheckPath(n, m-1,s1);
        }

        public void CheckConsecutivePath(int n, int m, string s1)
        {
            StringBuilder partial = new StringBuilder(); ;
            while (matrix[n, m] != 0)
            {
                while (path[n, m] == '0')
                {
                    partial.Append(s1[n-1]);
                    n--; m--;
                }
                if (partial.Length > 1) Console.WriteLine(partial.ToString());
                partial = new StringBuilder();
                if (path[n, m] == '1') n--;
                else if (path[n, m] == '2') m--;
            }
        }
    }
}
