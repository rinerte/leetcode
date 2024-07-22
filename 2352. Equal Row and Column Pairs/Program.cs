// Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) such that row ri and column cj are equal.

// A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).
public int EqualPairs(int[][] grid) {
    int count =0;
    for(int row=0;row<grid.Length;row++){
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid.Length;j++){
                if(grid[row][j]!=grid[j][i]) break;
                if(j==grid.Length-1) count++;
            }
        }
    }
    return count;
}