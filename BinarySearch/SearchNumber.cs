using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class SearchNumber
    {
        public double getNr(double left, double right, double precision, int number)
        {
            double mid = left + (right - left) / 2;
            if (Math.Abs(mid * mid - number) < precision)
                return mid;
            else if (mid * mid > number)
                return getNr(left, mid, precision, number);
            else return getNr(mid, right, precision, number);
        }
    }
}
