using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    
    public class RopeProblem
    {
        private List<int> finalSolution;
        private int min = Int32.MaxValue;
        public List<int> GetMin(List<int> cuts, int n)
        {
            Back(cuts, n, new List<int>());
            return finalSolution;
        }

        public void Back(List<int> cuts, int n, List<int> sol)
        {
            for (int i = 0; i < cuts.Count; i++)
            {
                sol.Add(cuts[i]);
                if (Valid(sol))
                {
                    if (sol.Count == cuts.Count)
                        CheckSol(sol, n);
                    else Back(cuts, n, sol);
                }
                sol.RemoveAt(sol.Count - 1);
            }
        }

        private void CheckSol(List<int> sol,int n)
        {
            int sum = 0;
            int[] values = new int[n + 1];
            values[0] = 1;
            values[n] = 1;
            for (int i = 0; i < sol.Count; i++)
            {
                values[sol[i]] = 1;
                int start = sol[i] - 1;
                int end = sol[i] + 1;
                while (values[start] != 1)
                    start--;
                while (values[end] != 1)
                    end++;
                sum += end - start;
            }
            if (sum < min)
            {
                min = sum;
                finalSolution = new List<int>(sol);
            }
        }
        
        //private int res = Int32.MaxValue;
        private List<int> finalList;
        public int Sol(List<int> values, int left, int right,List<int> sol)
        {
            int res = 0; ;
            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] > left && values[i] < right)
                {
                    res = right - left + Sol(values, left, values[i],sol) + Sol(values, values[i], right,sol);
                    //sol.RemoveAt(sol.Count - 1);
                }
                
            }

            return res;
        }

        private bool Valid(List<int> sol)
        {
            for (int i = 0; i < sol.Count - 1; i++)
                if (sol[i] == sol[sol.Count - 1]) return false;
            return true;
        }
    }
}
