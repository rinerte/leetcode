public bool ContainsDuplicate(int[] nums) {
        return nums.Distinct<int>().Count() != nums.Length;
}