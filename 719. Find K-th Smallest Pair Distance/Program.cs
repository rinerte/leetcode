// The distance of a pair of integers a and b is defined as the absolute difference between a and b.

// Given an integer array nums and an integer k, return the kth smallest distance among all the pairs nums[i] and nums[j] where 0 <= i < j < nums.length.

// INEFICIENT
// public int SmallestDistancePair(int[] nums, int k) {
//     int[] smallest = new int[k];
//     Array.Fill(smallest, int.MaxValue);

//     int n = nums.Length;        

//     for(int i=0; i<n; i++) {
//         for(int j=i+1;j<n;j++){
//             int d = Math.Abs(nums[j]-nums[i]);
            
//             int maxIndex = 0;
//             for (int l = 1; l < k; l++) {
//                 if (smallest[l] > smallest[maxIndex]) {
//                     maxIndex = l;
//                 }
//             }
//             if (d < smallest[maxIndex]) {
//                 smallest[maxIndex] = d;
//             }
//         }
//     }

//     Array.Sort(smallest);
//     return smallest[k-1];
// }
public int SmallestDistancePair(int[] nums, int k) {
    Array.Sort(nums);    
    int left = 0;
    int right = nums[nums.Length - 1] - nums[0];
    
    while (left < right) {
        int mid = left + (right - left) / 2;
        if (CountPairs(nums, mid) < k) {
            left = mid + 1;
        } else {
            right = mid;
        }
    }        
    return left;
}
private int CountPairs(int[] nums, int maxDist) {
    int count = 0;
    int j = 0;
    for (int i = 0; i < nums.Length; i++) {
        while (j < nums.Length && nums[j] - nums[i] <= maxDist) {
            j++;
        }
        count += j - i - 1;
    }
    return count;
}
