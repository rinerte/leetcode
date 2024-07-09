// You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. If a string is longer than the other, append the additional letters onto the end of the merged string.

// Return the merged string.
public string MergeAlternately(string word1, string word2) {
        
    StringBuilder sb = new();
    int index =0;

    while(index<word1.Length && index<word2.Length){
        sb.Append(word1[index]);
        sb.Append(word2[index]);
        index++;
    }
    if(index<word1.Length) sb.Append(word1.Substring(index));
    else sb.Append(word2.Substring(index));

    return sb.ToString();
}