// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

// Note that you must do this in-place without making a copy of the array.
public void MoveZeroes(int[] nums) {
    int index =0;
    for(int i=0;i<nums.Length;i++){
        if(nums[i]!=0){
            nums[index] = nums[i];
            index++;
        }
    }
    for(int i=1;i<nums.Length-index+1;i++) nums[^i]=0;
}