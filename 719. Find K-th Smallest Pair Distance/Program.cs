// The distance of a pair of integers a and b is defined as the absolute difference between a and b.

// Given an integer array nums and an integer k, return the kth smallest distance among all the pairs nums[i] and nums[j] where 0 <= i < j < nums.length.

public int SmallestDistancePair(int[] nums, int k) {
    int[] smallest = new int[k];
    Array.Fill(smallest, int.MaxValue);

    int n = nums.Length;        

    for(int i=0; i<n; i++) {
        for(int j=i+1;j<n;j++){
            int d = Math.Abs(nums[j]-nums[i]);
            
            int maxIndex = 0;
            for (int l = 1; l < k; l++) {
                if (smallest[l] > smallest[maxIndex]) {
                    maxIndex = l;
                }
            }
            if (d < smallest[maxIndex]) {
                smallest[maxIndex] = d;
            }
        }
    }

    Array.Sort(smallest);
    return smallest[k-1];
}