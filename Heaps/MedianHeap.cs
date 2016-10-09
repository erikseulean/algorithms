using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class MedianHeap
    {
        static bool bigger(int val1, int val2)
        {
            return val1 > val2;
        }

        static bool smaller(int val1, int val2)
        {
            return val1 < val2;
        }
        private Heap greaterHeap;
        private Heap smallerHeap;
        private double median = 0;
        private int counter = 0;
        public MedianHeap()
        {
            greaterHeap = new Heap(1000, bigger);
            smallerHeap = new Heap(1000, smaller);
        }

        public double Median { get { return median; } }

        public void Insert(int nr)
        {
            if (nr > median)
                greaterHeap.Insert(nr);
            else smallerHeap.Insert(nr);
            counter++;
            if (greaterHeap.Length > smallerHeap.Length)
                smallerHeap.Insert(greaterHeap.Remove());
            else if (smallerHeap.Length - greaterHeap.Length > 1)
                greaterHeap.Insert(smallerHeap.Remove());
            if (counter % 2 == 0)
                median = Convert.ToDouble(greaterHeap.Head + smallerHeap.Head) / 2;
            else median = smallerHeap.Head;
        }

       
    }
}
