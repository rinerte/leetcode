//You are given an integer array nums of size n.

//Consider a non-empty subarray from nums that has the maximum possible bitwise AND.

//In other words, let k be the maximum value of the bitwise AND of any subarray of nums. Then, only subarrays with a bitwise AND equal to k should be considered.
//Return the length of the longest such subarray.

//The bitwise AND of an array is the bitwise AND of all the numbers in it.

//A subarray is a contiguous sequence of elements within an array.
public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int max = 0;
        foreach (int num in nums)
        {
            max = Math.Max(max, num);
        }
        int ans = 0;
        int temp = 0;
        foreach (int num in nums)
        {
            if (num == max)
            {
                temp++;
            }
            else
            {
                temp = 0;
            }

            ans = Math.Max(ans, temp);
        }
        return ans;
    }
}