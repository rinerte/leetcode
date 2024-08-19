// Given an integer n, return true if it is a power of two. Otherwise, return false.

// An integer n is a power of two, if there exists an integer x such that n == 2x.
public bool IsPowerOfTwo(int n) {
    while (n>1){
        if((int)(n & 1) == 1) return false;
        n= n >> 1;
    }
    return n == 1;
}