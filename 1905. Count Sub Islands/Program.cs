// You are given two m x n binary matrices grid1 and grid2 containing only 0's (representing water) and 1's (representing land). An island is a group of 1's connected 4-directionally (horizontal or vertical). Any cells outside of the grid are considered water cells.

// An island in grid2 is considered a sub-island if there is an island in grid1 that contains all the cells that make up this island in grid2.

// Return the number of islands in grid2 that are considered sub-islands.
public class Solution
{
    // Directions in which we can traverse inside the grids.
    private readonly int[][] directions = new int[][]
    {
        new int[] { 0, 1 },
        new int[] { 1, 0 },
        new int[] { 0, -1 },
        new int[] { -1, 0 }
    };

    private bool IsCellLand(int x, int y, int[][] grid)
    {
        return grid[x][y] == 1;
    }

    private class UnionFind
    {
        private readonly int[] parent;
        private readonly int[] rank;

        public UnionFind(int n)
        {
            parent = new int[n];
            rank = new int[n];
            for (int i = 0; i < n; ++i)
            {
                parent[i] = i;
                rank[i] = 0;
            }
        }
        public int Find(int u)
        {
            if (parent[u] != u)
            {
                parent[u] = Find(parent[u]);
            }
            return parent[u];
        }
        public void UnionSets(int u, int v)
        {
            int rootU = Find(u);
            int rootV = Find(v);
            if (rootU != rootV)
            {
                if (rank[rootU] > rank[rootV])
                {
                    parent[rootV] = rootU;
                }
                else if (rank[rootU] < rank[rootV])
                {
                    parent[rootU] = rootV;
                }
                else
                {
                    parent[rootV] = rootU;
                    rank[rootU]++;
                }
            }
        }
    }
    private int ConvertToIndex(int x, int y, int totalCols)
    {
        return x * totalCols + y;
    }

    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        int totalRows = grid2.Length;
        int totalCols = grid2[0].Length;
        UnionFind uf = new UnionFind(totalRows * totalCols);

        // Traverse each land cell of 'grid2'.
        for (int x = 0; x < totalRows; ++x)
        {
            for (int y = 0; y < totalCols; ++y)
            {
                if (IsCellLand(x, y, grid2))
                {
                    foreach (int[] direction in directions)
                    {
                        int nextX = x + direction[0];
                        int nextY = y + direction[1];
                        if (
                            nextX >= 0 &&
                            nextY >= 0 &&
                            nextX < totalRows &&
                            nextY < totalCols &&
                            IsCellLand(nextX, nextY, grid2)
                        )
                        {
                            uf.UnionSets(
                                ConvertToIndex(x, y, totalCols),
                                ConvertToIndex(nextX, nextY, totalCols)
                            );
                        }
                    }
                }
            }
        }

        bool[] isSubIsland = new bool[totalRows * totalCols];
        for (int i = 0; i < isSubIsland.Length; i++)
        {
            isSubIsland[i] = true;
        }
        for (int x = 0; x < totalRows; ++x)
        {
            for (int y = 0; y < totalCols; ++y)
            {
                if (IsCellLand(x, y, grid2) && !IsCellLand(x, y, grid1))
                {
                    int root = uf.Find(ConvertToIndex(x, y, totalCols));
                    isSubIsland[root] = false;
                }
            }
        }

        int subIslandCounts = 0;
        for (int x = 0; x < totalRows; ++x)
        {
            for (int y = 0; y < totalCols; ++y)
            {
                if (IsCellLand(x, y, grid2))
                {
                    int root = uf.Find(ConvertToIndex(x, y, totalCols));
                    if (isSubIsland[root])
                    {
                        subIslandCounts++;
                        isSubIsland[root] = false;
                    }
                }
            }
        }

        return subIslandCounts;
    }
}