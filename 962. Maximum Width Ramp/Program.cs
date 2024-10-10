// A ramp in an integer array nums is a pair (i, j) for which i < j and nums[i] <= nums[j]. The width of such a ramp is j - i.

// Given an integer array nums, return the maximum width of a ramp in nums. If there is no ramp in nums, return 0.public class Solution {
    public int MaxWidthRamp(int[] nums) {
        Stack<int> stack = new();
        for(int i=0;i<nums.Length; i++){
            if(!stack.Any() || nums[stack.Peek()]>nums[i]) stack.Push(i);
        }
        int maxW =0;

        for(int i = nums.Length-1;i>=0;i--){
            while(stack.Any() && nums[stack.Peek()]<=nums[i]){
                maxW = Math.Max(maxW, i - stack.Peek());
                stack.Pop();
            }
        }
        return maxW;
    }
}