// You are given an array of strings products and a string searchWord.

// Design a system that suggests at most three product names from products after each character of searchWord is typed. Suggested products should have common prefix with searchWord. If there are more than three products with a common prefix return the three lexicographically minimums products.

// Return a list of lists of the suggested products after each character of searchWord is typed.

public class Solution {

    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        IList<IList<string>> list = new List<IList<string>>();
        Trie t = new();
        foreach(var p in products) t.Insert(p);

        for(int i=1;i<=searchWord.Length;i++){
            list.Add(t.Suggest(searchWord.Substring(0,searchWord.Length-(searchWord.Length-i))));
        }
        return list;
    }
    
}
public class Trie {
//97
    bool[] values;
    public Trie[] next;
    Trie root;
    public bool endWord;

    public Trie() {
        root = this;
        next = new Trie[26];
        values = new bool[26];        
    }
    public IList<string> Suggest(string prefix){
        IList<string> list = new List<string>();
        var head = root;
        for (int i = 0; i < prefix.Length; i++) {
            if (head == null || head?.values[prefix[i] - 97] == false) return list;
            head = head.next[prefix[i] - 97];
        }
        PriorityQueue<(Trie trie, string word), string> pq = new();
        pq.Enqueue((head, prefix), prefix);

        while (pq.Count > 0 && list.Count < 3) {
            var (trie, word) = pq.Dequeue();
            if (trie.endWord) {
                list.Add(word);
            }
            for (int i = 0; i < 26; i++) {
                if (trie.next[i] != null) {
                    string newWord = word + (char)(i + 97);
                    pq.Enqueue((trie.next[i], newWord), newWord);
                }
            }
        }
        return list;
    }
    public void Insert(string word) {
        var head = root;
        for(int i=0;i<word.Length;i++){
            head.values[word[i]-97] = true;
            head.next[word[i]-97] = head.next[word[i]-97] ?? new();
            head = head.next[word[i]-97];
        }
        head.endWord = true;
    }
    
    public bool Search(string word) {
        var head = root;
        for(int i=0;i<word.Length;i++){
            if(head==null || head?.values[word[i]-97] == false) return false;
            head = head.next[word[i]-97];
        }
        return head.endWord;
    }
    
    public bool StartsWith(string prefix) {
        var head = root;
        for(int i=0;i<prefix.Length;i++){
            if(head==null || head?.values[prefix[i]-97] == false) return false;
            head = head.next[prefix[i]-97];
        }
        return true;
    }
    public bool this[int i]
    {
        get { return values[i]; }
        set { values[i] = value; }
    }
}