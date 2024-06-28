public bool IsPalindrome(string s) {
    int start = 0;
    int end = s.Length-1;

    while(start < end)
    {
        if (char.IsLetterOrDigit(s[start]) && char.IsLetterOrDigit(s[end]))
        {
            if (char.ToLower(s[start]) != char.ToLower(s[end])) return false;
            else
            {
                start++;
                end--;
            }
        }
        else if (char.IsLetterOrDigit(s[start]))
        {
            end--;
        }
        else start++;
    }
    return true;
}