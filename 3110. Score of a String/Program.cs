﻿// You are given a string s. The score of a string is defined as the sum of the absolute difference between the ASCII values of adjacent characters.
// Return the score of s.

public int ScoreOfString(string s) {
        byte[] asc = Encoding.ASCII.GetBytes(s);
        int sum =0;
        for(int i=1;i<asc.Length;i++){
            sum+=Math.Abs(asc[i]-asc[i-1]);
        }
        return sum;
}