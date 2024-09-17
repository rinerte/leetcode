// A sentence is a string of single-space separated words where each word consists only of lowercase letters.

// A word is uncommon if it appears exactly once in one of the sentences, and does not appear in the other sentence.

// Given two sentences s1 and s2, return a list of all the uncommon words. You may return the answer in any order.
public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        Dictionary<string,int> dict = new();
        foreach(string s in s1.Split()){
            if(dict.ContainsKey(s)) dict[s]++;
            else dict[s] = 1;
        }
        foreach(string s in s2.Split()){
            if(dict.ContainsKey(s)) dict[s]++;
            else dict[s] = 1;
        }

        return dict.Where(i=>i.Value==1).Select(i=>i.Key).ToArray();
    }
}