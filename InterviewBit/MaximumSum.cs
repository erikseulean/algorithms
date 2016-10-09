using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class MaximumSum
    {
        public int GetSum(List<int> a)
        {
            return MaxSum(a, 0, 0, 0, a.Count - 1);
        }

        public int MaxSum(List<int> a, int sum, int k, int left, int right)
        {
            if (k == a.Count) return sum;

            int leftS = sum + a[left];
            if (a[left + 1] > a[right])
                leftS = MaxSum(a, leftS, k + 2, left + 2, right);
            else leftS = MaxSum(a, leftS, k + 2, left, right - 1);

            int rightS = sum + a[right];
            if (a[left] > a[right - 1])
                rightS = MaxSum(a, rightS, k + 2, left + 1, right);
            else rightS = MaxSum(a, rightS, k + 2, left, right - 2);

            return Math.Max(leftS, rightS);
        }
    }
}
