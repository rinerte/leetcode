//You are given two arrays rowSum and colSum of non-negative integers where rowSum[i] is the sum of the elements in the ith row and colSum[j] is the sum of the elements of the jth column of a 2D matrix. In other words, you do not know the elements of the matrix, but you do know the sums of each row and column.

//Find any matrix of non-negative integers of size rowSum.length x colSum.length that satisfies the rowSum and colSum requirements.

//Return a 2D array representing any matrix that fulfills the requirements. It's guaranteed that at least one matrix that fulfills the requirements exists.
public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
{
    int[][] arr = new int[rowSum.Length][];
    for (int i = 0; i < arr.Length; i++) arr[i] = new int[colSum.Length];

    while (rowSum.Max() != 0)
    {
        int i = OurMaxIndex(rowSum);
        int j = OurMaxIndex(colSum);

        int min1 = OurMin(rowSum);
        int min2 = OurMin(colSum);
        int decrement = Math.Min(min1, min2);

        rowSum[i] -= decrement;
        colSum[j] -= decrement;
        arr[i][j] += decrement;
    }

    return arr;
}
int OurMaxIndex(int[] arr)
{
    int max = 0;
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
            index = i;
        }
    }
    return index;

}
int OurMin(int[] arr)
{
    int min = int.MaxValue;
    foreach (int i in arr)
    {
        if (i != 0 && i < min) min = i;
    }
    return min;
}