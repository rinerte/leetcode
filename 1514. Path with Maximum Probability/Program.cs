// You are given an undirected weighted graph of n nodes (0-indexed), represented by an edge list where edges[i] = [a, b] is an undirected edge connecting the nodes a and b with a probability of success of traversing that edge succProb[i].

// Given two nodes start and end, find the path with the maximum probability of success to go from start to end and return its success probability.

// If there is no path from start to end, return 0. Your answer will be accepted if it differs from the correct answer by at most 1e-5.

public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node) {
    
    List<(int, double)>[] graph = new List<(int, double)>[n];
    
    for (int i = 0; i < n; i++)
        graph[i] = new List<(int, double)>();

    for (int i = 0; i < edges.Length; i++)
    {
        int u = edges[i][0];
        int v = edges[i][1];
        double prob = succProb[i];
        graph[u].Add((v, prob));
        graph[v].Add((u, prob)); 
    }

    PriorityQueue<(int node, double prob), double> pq = new PriorityQueue<(int, double), double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));
    pq.Enqueue((start_node, 1.0), 1.0);

    double[] maxProb = new double[n];
    maxProb[start_node] = 1.0;

    while (pq.Count > 0)
    {
        var (node, currProb) = pq.Dequeue();

        if (node == end_node)
            return currProb;

        foreach (var (next, edgeProb) in graph[node])
        {
            double newProb = currProb * edgeProb;
            if (newProb > maxProb[next])
            {
                maxProb[next] = newProb;
                pq.Enqueue((next, newProb), newProb);
            }
        }
    }

    return 0.0;
}