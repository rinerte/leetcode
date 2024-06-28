public int CombinationSum4(int[] nums, int target) {
    int[] dp = new int[target+1];
        dp[0] = 1;

    for(int i = 1; i < dp.Length; i++)
    {
        int sum = 0;
        
        foreach(int x in nums)
        {
            if(i-x>=0 && i-x<=i)
            {
                sum += dp[i - x];
            }
        }
        dp[i] = sum;
    }
    return dp[target];
}