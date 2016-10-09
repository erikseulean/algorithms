using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRemoveAndAdd
{
    class Program
    {
        //replace each character 'a' with 'dd'
        //remove each 'b'
        static void Main(string[] args)
        {
            DoStuff("baacdabb");
        }

        public static void DoStuff(string s)
        {
            if(String.IsNullOrEmpty(s)) return;
            //consider this as input
            int len = s.Length;
            char[] word = new char[len + 20];
            int i;
            for (i = 0; i < len; i++)
                word[i] = s[i];

            //algo
            int tail = 0;
            i = 0;
            int j = 0;
            int count = 0;
            if (word[0] == 'a') count++;
            for (i = 0; i < len; i++)
            {
                if (word[i] == 'a') count++;
                if (word[i] != 'b')
                {
                    word[tail] = word[i];
                    tail++;
                }
            }

            len = tail + count;
            j = len-1;
            while (tail > 0)
            {
                word[j] = word[tail - 1];
                if (word[j] == 'a')
                {
                    word[j] = 'd';
                    word[j - 1] = 'd';
                    j--;
                }
                tail--;
                j--;
            }
            string newWord = word.ToString();
        }
    }
}
