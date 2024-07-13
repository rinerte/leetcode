//You are given an integer array nums consisting of n elements, and an integer k.

//Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.
public double FindMaxAverage(int[] nums, int k)
{
    double max = double.MinValue;
    int sum = 0;
    for (int i = 0; i < k; i++) sum += nums[i];
    max = (double)sum / (double)k;

    for (int i = k; i < nums.Length; i++)
    {
        sum -= nums[i - k];
        sum += nums[i];
        max = Math.Max((double)sum / (double)k, max);
    }

    return max;
}