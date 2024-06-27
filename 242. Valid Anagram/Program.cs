public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            for(int i = 0; i < sArray.Length; i++)
            {
                if (tArray[i] != sArray[i]) return false;
            }
            return true;
}