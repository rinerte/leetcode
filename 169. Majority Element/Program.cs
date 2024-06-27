public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
                if (dict[nums[i]] > dict[max]) max = nums[i];
            }
            return max;
}