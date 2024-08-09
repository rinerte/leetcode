// A 3 x 3 magic square is a 3 x 3 grid filled with distinct numbers from 1 to 9 such that each row, column, and both diagonals all have the same sum.

// Given a row x col grid of integers, how many 3 x 3 contiguous magic square subgrids are there?

// Note: while a magic square can only contain numbers from 1 to 9, grid may contain numbers up to 15.
public int NumMagicSquaresInside(int[][] grid) {        
    if(grid.Length<3 || grid[0].Length<3) return 0;
    int count = 0;
    for(int i=0;i<grid.Length-2;i++){
        for(int j=0; j<grid[0].Length-2;j++){
            int s = grid[i][j] + grid[i][j+1] + grid[i][j+2];
            bool distinct = true;
            HashSet<int> set = new();

            for(int k=0;k<3;k++){
                for(int l=0;l<3;l++){
                    if(set.Contains(grid[i+k][j+l])) distinct = false;
                    if(grid[i+k][j+l]>9 || grid[i+k][j+l]<1) distinct = false;
                    set.Add(grid[i+k][j+l]);
                }
            }
            if(!distinct) continue;
            if(grid[i+1][j] + grid[i+1][j+1] + grid[i+1][j+2] != s) continue;
            if(grid[i+2][j] + grid[i+2][j+1] + grid[i+2][j+2] != s) continue;

            if(grid[i][j] + grid[i+1][j] + grid[i+2][j] != s) continue;
            if(grid[i][j+1] + grid[i+1][j+1] + grid[i+2][j+1] != s) continue;
            if(grid[i][j+2] + grid[i+1][j+2] + grid[i+2][j+2] != s) continue;

            if(grid[i][j] + grid[i+1][j+1] + grid[i+2][j+2] != s) continue;
            if(grid[i][j+2] + grid[i+1][j+1] + grid[i+2][j] != s) continue;
            count++;
        }
    }
    return count;
}