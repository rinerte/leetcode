﻿public int[] CountBits(int n) {
        int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                bits[i] = bits[i >> 1] + (i & 1);
            }
            return bits;
}