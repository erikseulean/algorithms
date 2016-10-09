using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class WordsBFS
    {
        private Queue<string> words;
        private Dictionary<string,string> path;
        private HashSet<string> visited;
        public WordsBFS()
        {
            words = new Queue<string>();
            path = new Dictionary<string, string>();
            visited = new HashSet<string>();
        }

        public void BFS(string start, string word, List<string> list)
        {
            path.Add(start, string.Empty);
            visited.Add(start);
            words.Enqueue(start);
            while (words.Count > 0)
            {
                string node = words.Dequeue();
                for (int i = 0; i < list.Count; i++)
                {
                    if (OneStep(node, list[i]))
                    {
                        if (list[i] == word)
                        {
                            path.Add(list[i], node);
                            Print(word, start);
                        }
                        else if (!visited.Contains(list[i]))
                        {
                            words.Enqueue(list[i]);
                            visited.Add(list[i]);
                            path.Add(list[i], node);
                        }
                    }
                }
            }
        }

        public void Print(string word,string start)
        {
            while(word != start)
            {
                Console.Write(word + " ");
                word = path[word];
            }
            Console.Write(word + " ");
        }

        private bool OneStep(string word, string newWord)
        {
            int changes = 0;
            for (int i = 0; i < word.Length; i++)
                if (word[i] != newWord[i])
                    changes++;
            if (changes == 1)
                return true;
            return false;
        }
    }
}
