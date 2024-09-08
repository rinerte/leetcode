// There are n cities numbered from 0 to n - 1 and n - 1 roads such that there is only one way to travel between two different cities (this network form a tree). Last year, The ministry of transport decided to orient the roads in one direction because they are too narrow.

// Roads are represented by connections where connections[i] = [ai, bi] represents a road from city ai to city bi.

// This year, there will be a big event in the capital (city 0), and many people want to travel to this city.

// Your task consists of reorienting some roads such that each city can visit the city 0. Return the minimum number of edges changed.

// It's guaranteed that each city can reach city 0 after reorder.
public class Solution {
    public int MinReorder(int n, int[][] roads) {
        List<List<(int sign, int conn)>> adj = new();
        int count = 0;
        for(int i = 0; i < n; i++)
        { 
            adj.Add(new List<(int sign, int conn)>()); 
        }
        foreach(int[] road in roads){
            adj[road[0]].Add((1, road[1])); 
            adj[road[1]].Add((0, road[0])); 
        }
        DFS(0, -1);

        return count;
        void DFS(int curr, int par){            
            foreach((int sign, int conn) nei in adj[curr]){
                if(nei.conn == par) continue; 

                count += nei.sign; 
                DFS(nei.conn, curr); 
            }
        }
    }    
}