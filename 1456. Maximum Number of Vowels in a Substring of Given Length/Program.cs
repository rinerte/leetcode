// Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

// Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.
public int MaxVowels(string s, int k) {
    int count =0;
    for(int i=0;i<Math.Min(k,s.Length);i++){
        if(isVowel(s[i])) count++;
    }
    int max = count;
    
    for(int i=k;i<s.Length;i++){
        if(isVowel(s[i-k])) count--;
        if(isVowel(s[i])) count++;
        max = Math.Max(count,max);
    }
    return max;
}

bool isVowel(char c){
    return "aeiou".Contains(c);
}