// There is only one character 'A' on the screen of a notepad. You can perform one of two operations on this notepad for each step:

// Copy All: You can copy all the characters present on the screen (a partial copy is not allowed).
// Paste: You can paste the characters which are copied last time.
// Given an integer n, return the minimum number of operations to get the character 'A' exactly n times on the screen.
public int MinSteps(int n) {
    if(n<2) return 0;
    if(n<6) return n;
    for(int i=2;i<n/2;i++)
    if(n%i==0) return MinSteps(n/i)+i;
    return n;
}