public int FindCenter(int[][] edges) {
        bool one = true;
        bool two = true;
        for(int i=1;i<edges.GetLength(0);i++){
            if(edges[i][0]!=edges[0][0] && edges[i][1]!=edges[0][0]) one = false;
            if(edges[i][0]!=edges[0][1] && edges[i][1]!=edges[0][1]) two = false;
        }
        return one?edges[0][0]:edges[0][1];
}