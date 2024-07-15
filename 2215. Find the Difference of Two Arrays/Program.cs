// Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

// answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
// answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
// Note that the integers in the lists may be returned in any order.

public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {        
    return new int[2][]{nums1.Distinct().Except(nums2).ToArray(),nums2.Distinct().Except(nums1).ToArray()};
}