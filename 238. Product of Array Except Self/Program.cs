// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

// You must write an algorithm that runs in O(n) time and without using the division operation.
public int[] ProductExceptSelf(int[] nums) {
    int[] prefix = new int[nums.Length];
    prefix[0]=1;
    for(int i=1;i<prefix.Length;i++){
        prefix[i]=prefix[i-1]*nums[i-1];
    }
    int[] post = new int[nums.Length];
    post[^1]=1;
    for(int i=post.Length-2;i>=0;i--){
        post[i]=post[i+1]*nums[i+1];
    }
    for(int i=0;i<nums.Length;i++){
        nums[i]=prefix[i]*post[i];
    }
    return nums;        
}