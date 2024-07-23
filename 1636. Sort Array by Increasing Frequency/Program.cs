// Given an array of integers nums, sort the array in increasing order based on the frequency of the values. If multiple values have the same frequency, sort them in decreasing order.

// Return the sorted array.
Dictionary<int,int> d;

public int[] FrequencySort(int[] nums) {
    d = new();     
    foreach(int i in nums){
        if(!d.ContainsKey(i)){
            d[i]=1;
        } else d[i]++;
    }
    Array.Sort(nums,(x,y)=>MyComparer(x,y));
    return nums;
}

int MyComparer(int x, int y){
    if(d[x]>d[y]) return 1;
    if (d[x]<d[y]) return -1;
    else {
        if(x>y) return -1;
        if(x<y) return 1;
    }
    return 0;
}