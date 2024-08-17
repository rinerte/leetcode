//You are given an m x n integer matrix points (0-indexed). Starting with 0 points, you want to maximize the number of points you can get from the matrix.

//To gain points, you must pick one cell in each row. Picking the cell at coordinates (r, c) will add points[r][c] to your score.

//However, you will lose points if you pick a cell too far from the cell that you picked in the previous row. For every two adjacent rows r and r + 1 (where 0 <= r < m - 1), picking cells at coordinates (r, c1) and (r + 1, c2) will subtract abs(c1 - c2) from your score.

//Return the maximum number of points you can achieve.
public long MaxPoints(int[][] points)
{

    return Dp(0, 0, points);
}

long Dp(int col, int row, int[][] points)
{
    long max = 0L;
    if (row == points.Length - 1)
    {
        if (points.Length > 1)
            max = points[row].Select((i, index) => i - (Math.Abs(index - col))).Max();
        else
            max = points[row].Max();
    }
    else
    {
        for (int i = 0; i < points[0].Length; i++)
        {
            long t = 0;
            if (row > 0)
            {
                t = points[row][i] - Math.Abs(i - col) + Dp(i, row + 1, points);
            }
            else
                t = points[row][i] + Dp(i, row + 1, points);
            max = t > max ? t : max;
        }
    }
    return max;
}