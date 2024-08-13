// A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings. There are various applications of this data structure, such as autocomplete and spellchecker.

// Implement the Trie class:

// Trie() Initializes the trie object.
// void insert(String word) Inserts the string word into the trie.
// boolean search(String word) Returns true if the string word is in the trie (i.e., was inserted before), and false otherwise.
// boolean startsWith(String prefix) Returns true if there is a previously inserted string word that has the prefix prefix, and false otherwise.
var t = new Trie();
t.Insert("apple");
Console.WriteLine(t.Search("apple"));
Console.WriteLine(t.Search("app"));
Console.WriteLine(t.StartsWith("app"));
t.Insert("app");
Console.WriteLine(t.Search("app"));
Console.WriteLine(t.Search("apple"));

public class Trie {
    Node root;
    public Trie() {
        root = new();
    }
    
    public void Insert(string word) {
        var head = root;
        for(int i=0;i<word.Length-1;i++){
            if(head[word[i]-97]==true) continue;
            head[word[i]-97]=true;
            head.next = head.next ?? new();
            head = head.next;
        }
        head[word[word.Length-1]-97]=true;
        head.SetEnd(word[word.Length-1]-97);
    }
    
    public bool Search(string word) {
        var head = root;
        
        for(int i=0;i<word.Length-1;i++){
            if(head[word[i]-97]==false) return false;
            if(head.next == null) return false;
            head = head.next;
            Console.WriteLine("Search with index = "+(word[i]-97));
        }
        Console.WriteLine("Search with index = "+ (word[word.Length-1]-97));
        if(head[word[word.Length-1]-97]==false) return false;
        Console.WriteLine("Search Ended");
        return (head.End(word[word.Length-1]-97));
    }
    
    public bool StartsWith(string prefix) {
        var head = root;
        for(int i=0;i<prefix.Length;i++){
            if(head[prefix[i]-97]==false) return false;
            if(head.next == null) return false;
            head = head.next;
        }
        return true;
    }
}
public class Node{
    public bool[] letters;
    public bool[] wordEnd;
    public Node next;
    public Node(){
        letters = new bool[26];
        wordEnd = new bool[26];      
    }
    public bool End(int index){
        return wordEnd[index];
    }
    public void SetEnd(int index){
        //Console.WriteLine("Set end with index ="+index+" to TRUE");
        wordEnd[index]=true;
    }
    public bool this[int i]
    {
        get { return letters[i]; }
        set { letters[i] = value; }
    }
}