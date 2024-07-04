// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
public int MissingNumber(int[] nums) {        
    int sum = nums.Length;
    for(int i=0;i<nums.Length;i++){
        sum=sum+i-nums[i];
    }      
    return sum;
}