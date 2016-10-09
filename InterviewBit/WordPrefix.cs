using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Trie
    {
        public char Value { get; set; }
        public Trie[] Childs { get; set; }

        public Trie()
        {
            Childs = new Trie[26];
        }
    }

    public class TrieManager
    {
        public Trie trie { get; set; }

        public TrieManager()
        {
            trie = new Trie();
        }

        public void AddWord(string word)
        {
            Trie t = trie;
            for (int i = 0; i < word.Length; i++)
            {
                if (t.Childs[word[i] - 97] == null)
                    t.Childs[word[i] - 97] = new Trie() { Value = word[i] };
                t = t.Childs[word[i] - 97];
            }
        }
    }
    public class WordPrefix
    {
        TrieManager manager = new TrieManager();

        public List<string> GetPrefixes(List<string> words)
        {
            List<string> list = new List<string>();
            foreach (string word in words)
                manager.AddWord(word);
            StringBuilder sb;
            foreach (var word in words)
            {
                sb = new StringBuilder();
                Trie t = manager.trie;
                for(int i=0;i<word.Length;i++){
                    sb.Append(word[i]);
                    t = t.Childs[word[i]-97];
                    int j;
                    for(j=0;j<t.Childs.Length;j++)
                        if(t.Childs[j] != null && t.Childs[j].Value != word[i+1]) break;
                    if(j == 26){
                        list.Add(sb.ToString());
                        break;
                    }
                }
            }

            return list;
        }
    }
}
