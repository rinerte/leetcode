// Given a list of non-negative integers nums, arrange them such that they form the largest number and return it.

// Since the result may be very large, so you need to return a string instead of an integer.
public class Solution {
    public string LargestNumber(int[] nums) {        
        var numStrings = nums.Select(n => n.ToString()).ToArray();
        Array.Sort(numStrings, (x, y) => (y + x).CompareTo(x + y));
        if (numStrings[0] == "0") return "0";
        return string.Join("", numStrings);    
    }
    
}