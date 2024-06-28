public int SearchInsert(int[] nums, int target) {
    if (nums.Length == 1)
    {
        if (nums[0] >= target) return 0; else return 1;
    }

    int index = nums.Length / 2;
    int inc = index / 2;

    while (true)
    {
        if (index >= nums.Length || index==0) return index;
        if(nums[index] >= target && nums[index-1]<target) return index;
        if (nums[index] > target)
        {
            index -= index>0? inc == 0 ? 1 : inc:0;
            inc /= 2;
        }
        else
        {
            index += inc == 0 ? 1 : inc;
            inc /= 2;
        }
    }
}