public double ChampagneTower(int poured, int query_row, int query_glass) {
    double[][] cups = new double[query_row + 1][];

    for (int i = 0; i <= query_row; i++)
    {
        cups[i] = new double[i + 1];
    }

    cups[0][0] = poured;

    for (int i = 0; i < query_row; i++)
    {
        for (int j = 0; j < cups[i].Length; j++)
        {
            if (cups[i][j] > 1d)
            {
                double half = ((1d - cups[i][j]) * (-1d)) / 2d;
                cups[i][j] = 1;
                cups[i + 1][j] += half;
                cups[i + 1][j + 1] += half;
            }
        }
    }
    
    return cups[query_row][query_glass] > 1.0 ? 1.0 : cups[query_row][query_glass];
}