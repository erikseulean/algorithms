using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCup
{
    public class ShortestPalindrome
    {
        public string MaxPalindrome(string word)
        {
            int mid = word.Length / 2;
            int i = mid;
            int j = mid + 1;
            while (j != word.Length)
            {
                if (word[i] == word[j])
                {
                    i--;
                    j++;
                }
                else {
                    mid = mid+1;
                    if(mid+1 <= word.Length -1 && word[mid] == word[mid+1])
                    {
                        i = mid - 1;
                        j = mid + 2;
                    }
                    else
                    {
                        i = mid - 2;
                        j = mid;
                    }
                }
            }

            for (j = i; j >= 0; j--)
                word += word[j];
            return word;
        }
    }
}
