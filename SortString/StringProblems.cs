using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    public static class StringProblems
    {
        public static bool CheckString(string word)
        {
            if (word == null)
                throw new ArgumentNullException();
            List<char> chars = new List<char>(word.Length);
            for (int i = 0; i < word.Length; i++)
            {
                if (chars.Contains(word[i]))
                    return false;
                chars.Add(word[i]);
            }
            return true;
        }

        public static bool CheckNoExtraDataStructures(string word)
        {
            if (word == null)
                throw new ArgumentNullException();
            for (int i = 0; i < word.Length - 1; i++)
                for (int j = i + 1; j < word.Length; j++)
                    if (word[i] == word[j])
                        return false;
            return true;
        }

        public static char[] RemoveDuplicates(char[] word)
        {
            if (word == null)
                throw new ArgumentNullException();
            for (int i = 0; i < word.Length - 1; i++)
                for (int j = i + 1; j < word.Length; j++)
                    if (word[i] == word[j])
                    {
                        for (int aux = j; aux < word.Length - 1; aux ++)
                            word[aux] = word[aux + 1];
                        word[word.Length - 1] = ' ';
                    }
            return word;
        }

        public static bool CheckAnagram(string firstWord, string secondWord)
        {
            int[] array = new int[60];
            for (int i = 0; i < firstWord.Length; i++)
                array[firstWord[i] - 65]++;
            for (int i = 0; i < secondWord.Length; i++)
                array[secondWord[i] - 65]--;
            for (int i = 0; i < 60; i++)
                if (array[i] > 0)
                    return false;
            return true;
        }

        public static void ReplaceCharacter(ref string word)
        {
            StringBuilder builder = new StringBuilder(word);
            StringBuilder auxBuilder;
            for (int i = 0; i < builder.Length; i++)
                if (builder[i] == ' ')
                {
                    auxBuilder = new StringBuilder();
                    for (int j = 0; j < i; j++)
                        auxBuilder.Append(builder[j]);
                    auxBuilder.Append("%20");
                    for (int j = i + 1; j < builder.Length; j++)
                        auxBuilder.Append(builder[j]);
                    builder = auxBuilder;
                }
            word = builder.ToString();
        }

        public static bool IsRotation(string first, string second)
        {
            StringBuilder builder = new StringBuilder();
            int j = 0;
            if (first.Length != second.Length)
                return false;
            for (int i = 0; i < first.Length; i++)
                if (first[i] != second[j])
                    builder.Append(first[i]);
                else j++;
            return second.Substring(j).Contains(builder.ToString());

        }

        public static void RemoveDuplicatesAgain(ref char[] duplicates)
        {
            if (duplicates != null && duplicates.Length > 2)
            {
                int tail = 1;
                int i;
                for (i = 1; i < duplicates.Length; i++)
                {
                    int j = 0;
                    while (duplicates[i] != duplicates[j] && j < tail)
                        j++;
                    if (j == tail)
                    {
                        duplicates[tail] = duplicates[i];
                        tail ++;
                    }
                }
                for (i = tail; i < duplicates.Length; i++)
                    duplicates[i] = '0';
            }

        }

        public static void RemoveDuplicatesOn(ref char[] duplicates)
        {
            int[] data = new int[256];
            int count = 0;
            if (duplicates != null && duplicates.Length > 2)
            {
                int i;
                for (i = 0; i < duplicates.Length - 1; i++)
                    if (data[duplicates[i] - 65] == 0)
                    {
                        duplicates[count] = duplicates[i];
                        count++;
                        data[duplicates[i] - 65]++;
                    }
            }
            for (int i = count; i < duplicates.Length; i++)
                duplicates[i] = '0';


        }
    }
}