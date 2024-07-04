public int RemoveDuplicates(int[] nums) {
    int k = 0;
    for(int i=1;i<nums.Length;i++){
        if(nums[i]>nums[k]){
            k++;
            if(k<i){
                for(int j=i;j<nums.Length;j++){
                    int temp = nums[j];
                    nums[j] = nums[j-i+k];
                    nums[j-i+k] = temp;
                }
                i=k;
            }
        }
    }
    return k+1;
}