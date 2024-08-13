// A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings. There are various applications of this data structure, such as autocomplete and spellchecker.

// Implement the Trie class:

// Trie() Initializes the trie object.
// void insert(String word) Inserts the string word into the trie.
// boolean search(String word) Returns true if the string word is in the trie (i.e., was inserted before), and false otherwise.
// boolean startsWith(String prefix) Returns true if there is a previously inserted string word that has the prefix prefix, and false otherwise.
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