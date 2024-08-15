// Given an integer array nums and an integer k, return the kth largest element in the array.

// Note that it is the kth largest element in the sorted order, not the kth distinct element.

// // Can you solve it without sorting?

public int FindKthLargest(int[] nums, int k) {
    PriorityQueue<int,int> q = new();
    foreach(var n in nums) q.Enqueue(n,-n);
    for(int i=0;i<k-1;i++) q.Dequeue();
    return q.Dequeue();
}