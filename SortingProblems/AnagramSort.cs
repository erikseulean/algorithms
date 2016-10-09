using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    public class AnagramSort
    {

        private bool CheckAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            var counter = new int[100];
            foreach (char t in s1)
                counter[t - 65] ++;
            foreach (char t in s2)
                counter[t - 65]--;
            return counter.All(t => t == 0);
        }

        public void qSort(ref string[] array, int left, int right)
        {
            string pivot = array[left + (right - left)/2];
            int mid = left + (right - left)/2;
            int i = left;
            int j = right;
            while (i < j)
            {
                while (CheckAnagrams(array[i], pivot)) i++;
                while (!CheckAnagrams(array[j], pivot)) j--;
                if (i <= j)
                {
                    string aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                    i++;
                    j--;
                }
            }

            if (i < right) qSort(ref array, i, right);
            if (j > left) qSort(ref array, left + 1, j);
        }
    }
}
