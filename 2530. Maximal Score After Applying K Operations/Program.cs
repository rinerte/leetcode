// You are given a 0-indexed integer array nums and an integer k. You have a starting score of 0.

// In one operation:

// choose an index i such that 0 <= i < nums.length,
// increase your score by nums[i], and
// replace nums[i] with ceil(nums[i] / 3).
// Return the maximum possible score you can attain after applying exactly k operations.

// The ceiling function ceil(val) is the least integer greater than or equal to val.
public class Solution {
    public long MaxKelements(int[] nums, int k) {
        PriorityQueue<int,int> queue = new(nums.Select(num=>(num,-num)));
        long score =0;
        for(int i=0;i<k;i++){
            int number = queue.Dequeue();
            score+=number;
            number = number % 3 == 0 ? number/3 : number / 3 + 1;
            queue.Enqueue(number,-number);
        }
        return score;
    }
}