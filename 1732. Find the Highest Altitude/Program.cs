public int LargestAltitude(int[] gain) {
    int max =0;
    int current =0;
    for(int i=0;i<gain.Length;i++){
        current+=gain[i];
        if(max<current) max=current;
    }
    return max;
}