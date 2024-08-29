// On a 2D plane, we place n stones at some integer coordinate points. Each coordinate point may have at most one stone.

// A stone can be removed if it shares either the same row or the same column as another stone that has not been removed.

// Given an array stones of length n where stones[i] = [xi, yi] represents the location of the ith stone, return the largest possible number of stones that can be removed.
public class Solution {

    public int RemoveStones(int[][] stones) {
        int n = stones.Length;
        UnionFind uf = new UnionFind(20002);

        for (int i = 0; i < n; i++) {
            uf.Union(stones[i][0], stones[i][1] + 10001);
        }

        return n - uf.ComponentCount;
    }

    class UnionFind {

        private int[] parent; 
        public int ComponentCount { get; private set; }
        private HashSet<int> uniqueNodes; 

        public UnionFind(int n) {
            parent = new int[n];
            for (int i = 0; i < n; i++) {
                parent[i] = -1; 
            }
            ComponentCount = 0;
            uniqueNodes = new HashSet<int>();
        }

        public int Find(int node) {
            if (!uniqueNodes.Contains(node)) {
                ComponentCount++;
                uniqueNodes.Add(node);
            }

            if (parent[node] == -1) {
                return node;
            }
            return parent[node] = Find(parent[node]);
        }

        public void Union(int node1, int node2) {
            int root1 = Find(node1);
            int root2 = Find(node2);

            if (root1 == root2) {
                return; 
            }

            parent[root1] = root2;
            ComponentCount--;
        }
    }
}