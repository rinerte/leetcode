// Two strings are considered close if you can attain one from the other using the following operations:

// Operation 1: Swap any two existing characters.
// For example, abcde -> aecdb
// Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
// For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
// You can use the operations on either string as many times as necessary.

// Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.
public bool CloseStrings(string word1, string word2) {
    if(word1.Length!=word2.Length) return false;

    int[] w1 = new int[26];
    int[] w2 = new int[26];

    for(int i=0;i<word1.Length;i++){
        w1[word1[i]-'a']++;
    }
    for(int i=0;i<word2.Length;i++){
        w2[word2[i]-'a']++;
    }
    int sum =0;
    for(int i=0;i<26;i++){
        if(w1[i]!=0){
            sum++;
            if(w2[i]!=0)sum--;
        }            
    }
    if(sum!=0) return false;

    Array.Sort(w1);
    Array.Sort(w2);
    for(int i=0;i<26;i++)
    if(w1[i]!=w2[i]) return false;

    return true;
}