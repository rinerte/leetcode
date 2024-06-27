public string LongestCommonPrefix(string[] strs) {
        int min = 200;
            foreach (string str in strs)
            {
                if(str.Length <= min) min = str.Length;
            }
            StringBuilder sb = new("");

            for(int i = 0; i < min; i++)
            {
                char c = strs[0][i];

                foreach (string str in strs)
                {
                    if (str[i] != c) return sb.ToString();
                }
                sb.Append(c);
            }
            return sb.ToString();
}