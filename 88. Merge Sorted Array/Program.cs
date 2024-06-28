 public void Merge(int[] nums1, int m, int[] nums2, int n) {
    var i = --m + n--;
    
    while (n >= 0)
        nums1[i--] = m >= 0 && nums1[m] > nums2[n] ? nums1[m--] : nums2[n--];
}