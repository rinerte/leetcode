// There are n cities numbered from 0 to n-1. Given the array edges where edges[i] = [fromi, toi, weighti] represents a bidirectional and weighted edge between cities fromi and toi, and given the integer distanceThreshold.

// Return the city with the smallest number of cities that are reachable through some path and whose distance is at most distanceThreshold, If there are multiple such cities, return the city with the greatest number.

// Notice that the distance of a path connecting cities i and j is equal to the sum of the edges' weights along that path.


int i = FindTheCity(6, new int[6][]{new int[3]{0,1,10},new int[3]{0,2,1},new int[3]{2,3,1},new int[3]{1,3,1},new int[3]{1,4,1},new int[3]{4,5,10}}, 20);
Console.WriteLine("" +i);

int[][] matrix;
Dictionary<int,int> count;

int FindTheCity(int n, int[][] edges, int distanceThreshold) {
    matrix = new int[n][];
    for(int i=0;i<n;i++){
        matrix[i]=new int[n];
        for(int j=0;j<0;j++) matrix[i][j] =-1;
    }
    count = new();
    for(int i=0;i<n;i++) count[i]=0;

    foreach(int[] e in edges){
        matrix[e[0]][e[1]]=e[2];
        matrix[e[1]][e[0]]=e[2];
    }

    for(int i=0;i<n;i++){
        for(int j=0;j<n;j++){
            Console.Write(matrix[i][j]);
        }
        Console.WriteLine();
    }

    for(int i=0;i<n;i++){
        Console.WriteLine("I = "+i+"");
        count[i] = Dp(n,i,matrix,distanceThreshold, new List<int>(),new List<int>());
    }

    int min  = int.MaxValue;
    int key = 0;
    foreach(int i in count.Keys) if(min>count[i]) {
        min=count[i];
        key = i;
    }
    Console.WriteLine(count[0]+" "+count[1]+" "+count[2]+" "+count[3]+" "+count[4]+" "+count[5]);
    return key;
}

int Dp(int n, int row, int[][] matrix, int distance, List<int> except, List<int> visitedInRow){
    
    Console.WriteLine("CALLED with row = "+row+"");
    except.Add(row);
    foreach(int i in except){Console.Write(" "+i);}
    Console.WriteLine();
    visitedInRow.AddRange(except);
    int max = visitedInRow.Distinct().Count();

    for(int i=0;i<n;i++){
        if(!except.Contains(i) && distance-matrix[row][i]>=0 && matrix[row][i]>0){
            max = Math.Max(max,Dp(n,i,matrix,distance-matrix[row][i],new List<int>(except),visitedInRow));
        }
    }
    return max;
}