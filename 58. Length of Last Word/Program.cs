public int LengthOfLastWord(string s) {
    bool wordStarted = false;
    int count = 0;

    for(int i = s.Length - 1; i >= 0; i--)
    {
        if(s[i] != ' ')
        {
            wordStarted = true;
            count++;
        } else
        {
            if(wordStarted) return count;
        }
    }
    return count;
}