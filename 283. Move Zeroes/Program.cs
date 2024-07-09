// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

// Note that you must do this in-place without making a copy of the array.
public void MoveZeroes(int[] nums) {
    for(int i=0;i<nums.Length;i++){
        if(nums[i]==0){
            for(int j=i;j<nums.Length;j++){
                if(nums[j]!=0){
                    int temp = nums[j];
                    nums[j]=nums[i];
                    nums[i]=temp;
                    i--;
                    break;
                }
                
            }
        }
    }
}