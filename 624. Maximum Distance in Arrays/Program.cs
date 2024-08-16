// You are given m arrays, where each array is sorted in ascending order.

// You can pick up two integers from two different arrays (each array picks one) and calculate the distance. We define the distance between two integers a and b to be their absolute difference |a - b|.

// Return the maximum distance.
public int MaxDistance(IList<IList<int>> arrays) {
    int answer = 0;
    int max = int.MaxValue;
    int index = 0;
    for(int i=0;i<arrays.Count();i++){
        if(max>=arrays[i][0]){  max = arrays[i][0]; index=i;}
    }
    var temp = arrays[index]; arrays.RemoveAt(index);
    answer = max; max = int.MinValue;
    for(int i=0;i<arrays.Count();i++){
        if(max<=arrays[i][^1]){max = arrays[i][^1];}
    }
    answer = Math.Abs(answer-max);
    arrays.Add(temp);
    max = int.MinValue;
    for(int i=0;i<arrays.Count();i++){
        if(max<=arrays[i][^1]){  max = arrays[i][^1]; index=i;}
    }
    arrays.RemoveAt(index);
    index = max;
    max = int.MaxValue;
    for(int i=0;i<arrays.Count();i++){
        if(max>=arrays[i][0]){  max = arrays[i][0];}
    }
    index = Math.Abs(max-index);

    return Math.Max(index,answer);
}