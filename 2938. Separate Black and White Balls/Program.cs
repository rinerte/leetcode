//There are n balls on a table, each ball has a color black or white.

//You are given a 0-indexed binary string s of length n, where 1 and 0 represent black and white balls, respectively.

//In each step, you can choose two adjacent balls and swap them.

//Return the minimum number of steps to group all the black balls to the right and all the white balls to the left.
public class Solution
{
    public long MinimumSteps(string s)
    {
        int whitePosition = 0;
        long totalSwaps = 0;
        for (int currentPos = 0; currentPos < s.Length; currentPos++)
        {
            if (s[currentPos] == '0')
            {
                totalSwaps += currentPos - whitePosition;

                whitePosition++;
            }
        }

        return totalSwaps;
    }
}