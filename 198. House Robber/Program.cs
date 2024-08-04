//You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

//Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

Dictionary<int, int> hash;

public int Rob(int[] nums)
{
    hash = new();
    return Dp(nums.Length - 1, nums);
}

int Dp(int count, int[] arr)
{
    if (count < 1) return arr[count];
    if (count == 1) return Math.Max(arr[count], arr[count - 1]);
    if (hash.ContainsKey(count)) return hash[count];
    int result = Math.Max(Dp(count - 1, arr), Dp(count - 2, arr) + arr[count]);
    hash[count] = result;
    return result;
}