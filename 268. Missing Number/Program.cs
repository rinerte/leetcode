// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
public int MissingNumber(int[] nums) {        
    int[] array = new int[nums.Length+1];
    foreach(int n in nums){
        array[n]=1;
    }
    for(int i=0;i<array.Length;i++) if(array[i]==0) return i;
    return 0;
}