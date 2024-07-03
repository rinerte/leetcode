public int MinDifference(int[] nums) {
    if(nums.Length<=4) return 0;
    Array.Sort(nums);
    
    return Math.Min(Math.Min(
        nums[nums.Length-4]-nums[0],nums[nums.Length-1]-nums[3]
    ),Math.Min(
        nums[nums.Length-3]-nums[1],nums[nums.Length-2]-nums[2]
    ));
}