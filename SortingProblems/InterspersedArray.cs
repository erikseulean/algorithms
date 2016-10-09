using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    public class InterspersedArray
    {
        public int Search(String[] strings, string word)
        {
            if (strings == null || strings.Length == 0 || String.IsNullOrEmpty(word))
                return -1;
            return BinarySearch(strings, word, 0, strings.Length - 1);
        }

        private int BinarySearch(string[] strings, string word, int left, int right)
        {
            if (left > right)
                return -1;
            int mid = left + (right - left)/2;
            int initMid = mid;

            while (strings[mid] == "")
                mid--;
            if (strings[mid] == word)
                return mid;
            else if (CompareStrings(strings[mid], word) > 1)
                return BinarySearch(strings, word, left, mid);
            return BinarySearch(strings, word, initMid+1, right);
        }

        private int CompareStrings(string s, string word)
        {
            bool reversed = false;
            if (s.Length > word.Length)
            {
                string aux = word;
                word = s;
                s = aux;
                reversed = true;
            }
            for(int i =0;i<s.Length;i++)
                if(s[i] > word[i]) //word is bigger than array element if reversed is true
                    if (reversed)
                        return 1;
                    else return -1;
            if (reversed) //means different lenghts
                return -1;
            return 1;
        }
    }
}
