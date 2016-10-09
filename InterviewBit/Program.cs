using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class CompareElements : IComparer<List<int>>
    {

        public int Compare(List<int> x, List<int> y)
        {
            int length;
            if (x.Count <= y.Count)
                length = x.Count;
            else length = y.Count;
            for (int i = 0; i < length; i++)
            {
                if (x[i] < y[i]) return -1;
            }

            if (x.Count <= y.Count) return -1;
            else return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeWords pal = new PalindromeWords();
            pal.getPalindrome("faBwYCBlE80lh2P5QRlIK6D5ClLiRIlMMFakPVY25IIjInyC2DW8yL9pBukw2jUw");
            Console.ReadLine();
        }

        public bool Compare(List<int> first, List<int> second)
        {
            int length;
            if (first.Count <= second.Count)
                length = first.Count;
            else length = second.Count;
            for (int i = 0; i < length; i++)
            {
                if (first[i] > second[i]) return false;
            }
            return true;
        }
    }
}
