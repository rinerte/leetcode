public int IntegerBreak(int n) {
        if (n <= 3) return n - 1;
        if (n % 3 == 0) return (int)Math.Pow(3, n / 3);
        if (n % 3 == 1) return (int)Math.Pow(3, n / 3 - 1)*4;
        else return (int)Math.Pow(3, n / 3)*2;
}