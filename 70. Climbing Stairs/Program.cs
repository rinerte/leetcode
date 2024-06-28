public int ClimbStairs(int n) {
    if (n <= 3) return n;
    List<int> fib = new();
    fib.AddRange(new int[] { 0, 1, 2 });

    for(int i = 3; i <= n; i++)
    {
        fib.Add(fib[i - 1] + fib[i - 2]);
    }
    return fib[n];
}