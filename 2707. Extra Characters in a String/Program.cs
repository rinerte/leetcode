// You are given a 0-indexed string s and a dictionary of words dictionary. You have to break s into one or more non-overlapping substrings such that each substring is present in dictionary. There may be some extra characters in s which are not present in any of the substrings.

// Return the minimum number of extra characters left over if you break up s optimally.
// public int MinExtraChar(string s, string[] dictionary) {
//         int maxVal = s.Length + 1;
//         int[] dp = new int[s.Length + 1];
//         Array.Fill(dp, maxVal);
//         dp[0] = 0;

//         HashSet<string> dictionarySet = new HashSet<string>(dictionary);

//         for (int i = 1; i <= s.Length; ++i)
//         {
//             dp[i] = dp[i - 1] + 1;
//             for (int l = 1; l <= i; ++l)
//             {
//                 if (dictionarySet.Contains(s.Substring(i - l, l)))
//                 {
//                     dp[i] = Math.Min(dp[i], dp[i - l]);
//                 }
//             }
//         }
//         return dp[s.Length];
        
// }
public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        var n = s.Length;
        var dp = Enumerable.Repeat(n, n + 1).ToArray();
        dp[0] = 0;

        for (var i = 0; i < n; i++)
        {
            if (dp[i] != n)
                foreach (var word in dictionary.Where(w => i + w.Length <= n && s[i..(i + w.Length)] == w))
                    dp[i + word.Length] = Math.Min(dp[i + word.Length], dp[i]);

            dp[i + 1] = Math.Min(dp[i + 1], dp[i] + 1);
        }

        return dp[n];
    }
}