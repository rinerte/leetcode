//An n x n grid is composed of 1 x 1 squares where each 1 x 1 square consists of a '/', '\', or blank space ' '. These characters divide the square into contiguous regions.

//Given the grid grid represented as a string array, return the number of regions.

//Note that backslash characters are escaped, so a '\' is represented as '\\'.

string[] g = new string[2] { " /", "/ " };
RegionsBySlashes(g);


 int RegionsBySlashes(string[] grid)
{
   
    //int gridSize = grid.Length;
    int[][] expandedGrid = new int[grid.Length * 3][];
    for (int i = 0; i < grid.Length*3; i++)
        expandedGrid[i] = new int[grid.Length * 3];

    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid.Length; j++)
        {
            int baseRow = i * 3;
            int baseCol = j * 3;
            if (grid[i][j] == '\\')
            {
                expandedGrid[baseRow][baseCol] = 1;
                expandedGrid[baseRow + 1][baseCol + 1] = 1;
                expandedGrid[baseRow + 2][baseCol + 2] = 1;
            }
            else if (grid[i][j] == '/')
            {
                expandedGrid[baseRow][baseCol + 2] = 1;
                expandedGrid[baseRow + 1][baseCol + 1] = 1;
                expandedGrid[baseRow + 2][baseCol] = 1;
            }
        }
    }

    int regionCount = 0;
    for (int i = 0; i < grid.Length * 3; i++)
    {
        for (int j = 0; j < grid.Length * 3; j++)
        {
            if (expandedGrid[i][j] == 0)
            {
                floodFill(expandedGrid, i, j);
                regionCount++;
            }
        }
    }
    return regionCount;
}

void floodFill(int[][] expandedGrid, int row, int col)
{
    int[][] DIRECTIONS = {
        new int[]{0,1},
        new int[]{0,-1},
        new int[]{1,0},
        new int[]{-1,0}
    };
    Queue<int[]> queue = new();
    expandedGrid[row][col] = 1;
    queue.Enqueue(new int[] { row, col });

    while (queue.Any())
    {
        int[] currentCell = queue.Dequeue();
        // Check all four directions from the current cell
        foreach (int[] direction in DIRECTIONS)
        {
            int newRow = direction[0] + currentCell[0];
            int newCol = direction[1] + currentCell[1];
            // If the new cell is valid and unvisited, mark it and add to queue
            if (isValidCell(expandedGrid, newRow, newCol))
            {
                expandedGrid[newRow][newCol] = 1;
                queue.Enqueue(new int[] { newRow, newCol });
            }
        }
    }
}
bool isValidCell(int[][] expandedGrid, int row, int col)
{
    int n = expandedGrid.Length;
    return (
        row >= 0 &&
        col >= 0 &&
        row < n &&
        col < n &&
        expandedGrid[row][col] == 0
    );
}