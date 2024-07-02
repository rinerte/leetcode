public bool IsPalindrome(int x) {
    var s = x.ToString().ToCharArray();

    for(int i=0; i<s.Length/2;i++){
        if(s[i]!=s[s.Length-1-i]) return false;
    }
    
    return true;
}