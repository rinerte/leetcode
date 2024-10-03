// Given an array of positive integers nums, remove the smallest subarray (possibly empty) such that the sum of the remaining elements is divisible by p. It is not allowed to remove the whole array.

// Return the length of the smallest subarray that you need to remove, or -1 if it's impossible.

// A subarray is defined as a contiguous block of elements in the array.
public class Solution {
    public int MinSubarray(int[] nums, int p) {
        int target = (int)(nums.Sum(x => (long)x) % p); 
        if(target ==0) return 0;

        Dictionary<int,int> dict = new();
        dict[0] = -1;

        long currSum =0;
        int minLen = nums.Length;

        for(int i=0;i<nums.Length; ++i){
            currSum = (currSum+nums[i]) % p;
            int needed = (int)((currSum - target + p) % p);
            if(dict.ContainsKey(needed)){
                minLen = Math.Min(minLen,i-dict[needed]);
            }

            dict[(int)currSum] = i;
        }
        return minLen == nums.Length?-1:minLen;
    }
}