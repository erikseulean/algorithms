using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrieImplementation;

namespace Trie
{
    public class Trie
    {
        private TrieNode trie;

        public Trie()
        {
            trie = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode t = trie;
            for (int i = 0; i < word.Length; i++)
            {
                int index = GetIndex(t, word[i]);
                if (index == -1)
                {
                    t.Childs[word[i] - 97] = new TrieNode() { Value = word[i] };
                    index = word[i] - 97;
                }
                t = t.Childs[index];
            }
        }

        public bool Find(string word)
        {
            TrieNode t = trie;
            for (int i = 0; i < word.Length; i++)
            {
                int index = GetIndex(t, word[i]);
                if (index == -1) return false;
                else t = t.Childs[index];
            }

            return true;
        }

        public int GetIndex(TrieNode t, char value)
        {
            if(t.Childs[value - 97] != null) return (int)(value - 97);
            else return -1;
        }
    }
}
