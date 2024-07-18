// Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.

 

// Example 1:

// Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
// Output: 6
// Explanation: [1,1,1,0,0,1,1,1,1,1,1]
// Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

public int LongestOnes(int[] nums, int k) {
    int zeroCount = 0;
    int maxOnes = 0;
    int p1 =0;
    int p2 =0;
    if(nums.Length<=k) return nums.Length;
    
    while(p2<nums.Length && p1<nums.Length-1){
        if(nums[p2]==0) zeroCount++;
        if(zeroCount>k){
            if(nums[p1]==1){
                    while(nums[p1]!=0 && p1<p2){
                    p1++;
                }
            } else{
                p1++;
            }        
            p2=p1;
            zeroCount=0;
        } else {
            p2++;
            maxOnes = Math.Max(p2-p1,maxOnes);
        }
    }
    return maxOnes;
}