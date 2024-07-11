// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

// A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

Console.WriteLine(IsSubsequence("aaaaaa","bbaaaa"));


static bool IsSubsequence(string s, string t) {
    int pt =0;        
    for(int i=0;i<s.Length;i++){
        if(pt>=t.Length) return false;
        if(s[i]!=t[pt]) i--;
        pt++;
    }
    return true;
}