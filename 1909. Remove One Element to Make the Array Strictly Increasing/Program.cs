// Given a 0-indexed integer array nums, return true if it can be made strictly increasing after removing exactly one element, or false otherwise. If the array is already strictly increasing, return true.

// The array nums is strictly increasing if nums[i - 1] < nums[i] for each index (1 <= i < nums.length).
public bool CanBeIncreasing(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
            {
                int[] newArr = nums.Where((v, n) => n != i).ToArray();
                bool result = true;

                for (int j = 1; j < newArr.Length; j++)
                {
                    if (newArr[j] <= newArr[j - 1])
                    {
                        result = false;
                    }
                }
                if (result) return result;
            }

            return false;
    }
}