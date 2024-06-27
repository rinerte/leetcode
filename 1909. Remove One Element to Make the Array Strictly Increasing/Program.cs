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