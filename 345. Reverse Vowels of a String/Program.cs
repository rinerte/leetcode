// Given a string s, reverse only all the vowels in the string and return it.

// The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

// Example 1:

// Input: s = "hello"
// Output: "holle"

public string ReverseVowels(string s) {        
    StringBuilder sb = new(s);
    int i=0,j=s.Length-1;
    while(i<=j){
        if(isVowel(sb[i]) && isVowel(sb[j])){
            var temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
            i++; j--;
        } else if(isVowel(sb[i])) j--; else i++;
    }
    return sb.ToString();
}
private bool isVowel(char s){
    return "aeiou".Contains(char.ToLower(s));
}