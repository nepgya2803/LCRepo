public class Solution {
    public class TrieNode
    {
        public TrieNode[] children;
        public string word = null; 
        public TrieNode()
        {
            children = new TrieNode[26];  
        }
    }

    public class Trie
    {
        TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            var current = root;

            foreach(var c in word)
            {
                if (current.children[c - 'a'] == null)
                {
                    current.children[c - 'a'] = new TrieNode();
                }
                var node =  current.children[c - 'a'];
                if (!string.IsNullOrWhiteSpace(node.word)) return;
                current = node;
            }
            current.word = word;
        }

        public string GetShortestWord(string word)
        {
            var current = root;

            foreach(var c in word)
            {
                if (current.children[c - 'a'] == null)
                {
                    return word;
                }
                current =  current.children[c - 'a'];
                if (!string.IsNullOrWhiteSpace(current.word)) return current.word;
            }
            return word;
        }
    }

    public string ReplaceWords(IList<string> dictionary, string sentence) {
        var trie = new Trie();
        foreach(var word in dictionary)
        {
            trie.Insert(word);
        }

        var splitSentence = sentence.Split(' ');
        var result = new StringBuilder();
        foreach(var splitWord in splitSentence)
        {
            result.Append(trie.GetShortestWord(splitWord)).Append(' ');
        }

        return result.ToString().Trim();
    }
}