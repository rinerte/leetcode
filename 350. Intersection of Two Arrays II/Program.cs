public int[] Intersect(int[] nums1, int[] nums2) {
    Dictionary<int,int> intCount = new();
    
    foreach(int i in nums1){
        if(intCount.ContainsKey(i)){
            intCount[i]++;
        } else {
            intCount[i] = 1;
        }
    }
    
    List<int> result = new();

    foreach(int i in nums2){
        if(intCount.ContainsKey(i)){
            if(intCount[i]-->0) result.Add(i);
        }
    }

    return result.ToArray();
}