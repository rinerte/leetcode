// For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).

// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

public string GcdOfStrings(string str1, string str2) {
    
    int index = 0;
    while(index<str1.Length && index<str2.Length){            
        if(str1[index]!=str2[index]) break;
        index++;
    }

    for(int i=index;i>0;i--){
        if(str1.Length%i!=0 || str2.Length%i!=0) continue;
        var s1 =String.Concat(Enumerable.Repeat(str1.Substring(0,i), str1.Length/i));
        var s2 =String.Concat(Enumerable.Repeat(str2.Substring(0,i), str2.Length/i));
        if(s1==str1 && s2==str2) return str1.Substring(0,i);
    }
    return "";
}