using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems.PeopleProblem
{
    public class People
    {
        public People(int height, int weight)
        {
            Height = height;
            Weight = weight;
        }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
