// You are given an array words of size n consisting of non-empty strings.

// We define the score of a string word as the number of strings words[i] such that word is a prefix of words[i].

// For example, if words = ["a", "ab", "abc", "cab"], then the score of "ab" is 2, since "ab" is a prefix of both "ab" and "abc".
// Return an array answer of size n where answer[i] is the sum of scores of every non-empty prefix of words[i].

// Note that a string is considered as a prefix of itself.
public class Solution {
    public int[] SumPrefixScores(string[] words) {
        var root = new Trie();

        foreach(string word in words){
            root.Insert(word);
        }
        int[] totals = new int[words.Length];

        for(int i=0;i<words.Length;i++){
            totals[i] = root.Sum(words[i]);
        }
        return totals;
    }

    class TrieNode{
        public int count = 0;
        public TrieNode[] children = new TrieNode[26];
    }
    class Trie{
        public TrieNode root = new();

        public void Insert(string word){
            TrieNode node = root;
            foreach(char c in word){
                int idx = c - 'a';
                if(node.children[idx]==null){
                    node.children[idx] = new TrieNode();
                }
                node.children[idx].count++;
                node = node.children[idx];
            }
        }
        public int Sum(string word){
            TrieNode node = root;
            int sum =0;
            foreach(char c in word){
                int idx = c -'a';
                if(node.children[idx]!=null){
                    sum+=node.children[idx].count;
                    node = node.children[idx];
                } else break;
            }
            return sum;
        }
    }
}