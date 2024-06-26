public int MaxProfit(int[] prices)
{
    if (prices.Length < 2) return 0;
    int profit = 0;
    int min = prices[0];

    for(int i = 0; i < prices.Length; i++)
    {
        if(min>prices[i]) min = prices[i];
        if (prices[i] - min > profit) profit = prices[i] - min;
    }
    return profit;
}