// You are given a string s consisting of lowercase English letters, and an integer k.

// First, convert s into an integer by replacing each letter with its position in the alphabet (i.e., replace 'a' with 1, 'b' with 2, ..., 'z' with 26). Then, transform the integer by replacing it with the sum of its digits. Repeat the transform operation k times in total.
public class Solution {
    public int GetLucky(string s, int k) {
        int sum = 0;
        foreach (char c in s) {
            int value = c-'`';
            sum += SumOfDigits(value);
        }
        for (int i = 1; i < k; i++) {
            sum = SumOfDigits(sum);
        }
        return sum;
    }
    private int SumOfDigits(int num) {
        int sum = 0;
        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}