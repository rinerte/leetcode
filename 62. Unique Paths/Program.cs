public int UniquePaths(int m, int n) {
    int[][] ar = new int[m][];
        
    for(int i = 0; i < m; i++)
    {
        ar[i] = new int[n];
        ar[i][0] = 1;
    }
    Array.Fill(ar[0], 1);

    for(int i = 1; i < m; i++)
    {
        for(int j = 1; j < n; j++)
        {
            ar[i][j] = ar[i - 1][j] + ar[i][j-1];
        }
    }

    return ar[m-1][n-1];
}