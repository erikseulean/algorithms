using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class WordJustification
    {
        public string GiveMeSpaces(int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
                sb.Append(" ");
            return sb.ToString();
        }

        public List<string> GetRows(List<string> words, int length)
        {
            Dictionary<int, int> listLength = new Dictionary<int, int>();
            List<string> final = new List<string>();
            List<List<string>> rows = new List<List<string>>();
            int currentLength = 0;
            int nrRows = 0;
            rows.Add(new List<string>());
            for (int i = 0; i < words.Count; i++)
            {
                if (currentLength + 1 + words[i].Length <= length)
                {
                    currentLength += words[i].Length + 1;
                    rows[nrRows].Add(words[i]);
                }
                else
                {
                    listLength.Add(nrRows, currentLength);
                    nrRows++;
                    rows.Add(new List<string>());
                    rows[nrRows].Add(words[i]);
                    currentLength = words[i].Length + 1;
                }
            }
            listLength.Add(nrRows, currentLength);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows.Count; i++)
            {
                int spaces = length - listLength[i] + rows[i].Count;
                int spacesPerWord;
                int extraSpaces;
                if (rows[i].Count > 1)
                {
                    spacesPerWord = spaces / (rows[i].Count - 1);
                    extraSpaces = spaces % (rows[i].Count - 1);
                }
                else
                {
                    spacesPerWord = spaces / rows[i].Count;
                    extraSpaces = spaces % (rows[i].Count);
                }
                sb.Append(rows[i][0]);
                sb.Append(GiveMeSpaces(spacesPerWord + extraSpaces));
                for (int j = 1; j < rows[i].Count-1; j++)
                {
                    sb.Append(rows[i][j]);
                    sb.Append(GiveMeSpaces(spacesPerWord));
                }
                if (rows[i].Count > 1)
                {
                    sb.Append(rows[i][rows[i].Count - 1]);
                    sb.Append(GiveMeSpaces(length - sb.Length - 1));
                } 
                final.Add(sb.ToString());
                sb = new StringBuilder();
            }
            return final;
        }

        public List<string> GetOptimized(List<string> words, int length)
        {
            List<string> final = new List<string>();
            int currentLength = 0;
            int currentStart = 0;

            for (int i = 0; i < words.Count; i++)
            {
                if (currentLength + 1 + words[i].Length <= length)
                    currentLength += 1 + words[i].Length;
                else
                {
                    StringBuilder sb = new StringBuilder();
                    int spaces = length - currentLength + (i - currentStart);
                    int spacesPerWord;
                    int extraSpaces;
                    if (i - currentStart > 0)
                    {
                        spacesPerWord = spaces / (i - currentStart - 1);
                        extraSpaces = spaces % (i - currentStart - 1);
                    }
                    else {
                        spacesPerWord = spaces;
                        extraSpaces = 0;
                    }
                    sb.Append(words[currentStart]);
                    sb.Append(GiveMeSpaces(spacesPerWord + extraSpaces));
                    for (int j = currentStart + 1; j < i-1; j++)
                    {
                        sb.Append(words[j]);
                        sb.Append(GiveMeSpaces(spacesPerWord));
                    }

                    sb.Append(words[i-1]);
                    sb.Append(GiveMeSpaces(length - sb.Length - 1));
                    
                    final.Add(sb.ToString());
                    currentLength = 0;
                    currentStart = i;
                }
            }
            return final;
        }
    }
}
