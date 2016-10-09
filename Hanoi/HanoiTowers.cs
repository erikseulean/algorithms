using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class HanoiTowers
    {
        public void StartHanoi(int n, MyStack first, MyStack middle, MyStack last)
        {

            if (n > 0)
            {
                StartHanoi(n - 1, first, last,middle);
                last.push(first.pull());
                StartHanoi(n - 1, middle, first, last);
            }
        }
    }
}
