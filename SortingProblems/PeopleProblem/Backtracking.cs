using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems.PeopleProblem
{
    public class Backtracking
    {
        private List<People> list; 
        public Backtracking(List<People> sorted)
        {
            list = sorted;
            solution = new People[list.Count];
        }

        private People[] finalSolution;
        private int maxLength = 0;
        private People[] solution;

        public void GetSolution()
        {
            People[] array = new People[list.Count];
            for(int i=0;i<list.Count;i++)
                Back(array,0,i);
            foreach(var item in finalSolution)
                if(item != null)
                    Console.WriteLine("(" + item.Height + " " + item.Weight + ") ");
            Console.WriteLine();
        }
        private void Back(People[] array,int nr,int i)
        {
            if(i < list.Count)
            {
                array[nr] = list[i];
                if (Valid(array,nr))
                {
                    if (array.Length > maxLength)
                        StoreSolution(array,nr);
                    Back(array,nr + 1,i+1);
                    Back(array,nr,i+1);
                } else Back(array,nr, i + 1);
            }
        }

        private void StoreSolution(People[] array,int nr)
        {
            maxLength = nr;
            finalSolution = new People[nr + 1];
            for (int i = 0; i <= nr; i++)
                finalSolution[i] = array[i];
        }

        private bool Valid(People[] array,int nr)
        {
            if (nr == 0)
                return true;
            if (array[nr].Weight <= array[nr - 1].Weight || array[nr].Height <= array[nr - 1].Height)
                return false;
            return true;
        }
    }
}
