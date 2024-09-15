//Given the string s, return the size of the longest substring containing each vowel an even number of times. That is, 'a', 'e', 'i', 'o', and 'u' must appear an even number of times.
public class Solution
{
    public int FindTheLongestSubstring(string s)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        map[0] = -1;

        int maxLength = 0;
        int currentMask = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];

            if (ch == 'a')
            {
                currentMask ^= (1 << 0);
            }
            else if (ch == 'e')
            {
                currentMask ^= (1 << 1);
            }
            else if (ch == 'i')
            {
                currentMask ^= (1 << 2);
            }
            else if (ch == 'o')
            {
                currentMask ^= (1 << 3);
            }
            else if (ch == 'u')
            {
                currentMask ^= (1 << 4);
            }

            if (map.ContainsKey(currentMask))
            {
                maxLength = Math.Max(maxLength, i - map[currentMask]);
            }
            else
            {
                map[currentMask] = i;
            }
        }

        return maxLength;
    }
}