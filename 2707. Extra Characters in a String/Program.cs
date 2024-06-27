public int MinExtraChar(string s, string[] dictionary) {
        int maxVal = s.Length + 1;
            int[] dp = new int[s.Length + 1];
            Array.Fill(dp, maxVal);
            dp[0] = 0;

            HashSet<string> dictionarySet = new HashSet<string>(dictionary);

            for (int i = 1; i <= s.Length; ++i)
            {
                dp[i] = dp[i - 1] + 1;
                for (int l = 1; l <= i; ++l)
                {
                    if (dictionarySet.Contains(s.Substring(i - l, l)))
                    {
                        dp[i] = Math.Min(dp[i], dp[i - l]);
                    }
                }
            }
            return dp[s.Length];
}