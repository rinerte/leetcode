// You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.

// Return the number of consistent strings in the array words.
public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> set = new();
        foreach(char c in allowed) set.Add(c);
        int count = 0;
        for(int i=0;i<words.Length;i++){
            foreach(char c in words[i]) if(!set.Contains(c)){
                count++;
                break;
            }
        }
        return words.Length-count;
    }
}