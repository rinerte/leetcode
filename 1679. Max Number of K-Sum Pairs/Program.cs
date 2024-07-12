// You are given an integer array nums and an integer k.

// In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

// Return the maximum number of operations you can perform on the array.\
public int MaxOperations(int[] nums, int k) {
    Array.Sort(nums);
    int i=0,j=nums.Length-1;
    int count =0;
    while(i<j){
        if(nums[i]+nums[j]>k) j--;
        else if(nums[i]+nums[j]<k) i++;
        else {
            i++;
            j--;
            count++;
        }
    }
    return count;
}