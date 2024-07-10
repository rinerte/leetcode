// Given an input string s, reverse the order of the words.

// A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

// Return a string of the words in reverse order concatenated by a single space.

// Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
using System.Text;

Console.WriteLine(ReverseWords("a the sky is blue"));

static string ReverseWords(string s) {        
    StringBuilder sb = new();
    int endWordIndex = s.Length-1;
    int startWordIndex = s.Length-1;
    while(endWordIndex>=0){
        if(s[endWordIndex]!=' '){
            startWordIndex=endWordIndex;
            while(startWordIndex>0 && s[startWordIndex-1]!=' '){
                startWordIndex--;
            }
            sb.Append(s.Substring(startWordIndex,endWordIndex-startWordIndex+1));
            sb.Append(' ');
            endWordIndex = startWordIndex-1;
        } else
        endWordIndex--;
    }
    sb.Length--;
    return sb.ToString();
}