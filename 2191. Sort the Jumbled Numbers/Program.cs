// You are given a 0-indexed integer array mapping which represents the mapping rule of a shuffled decimal system. mapping[i] = j means digit i should be mapped to digit j in this system.

// The mapped value of an integer is the new integer obtained by replacing each occurrence of digit i in the integer with mapping[i] for all 0 <= i <= 9.

// You are also given another integer array nums. Return the array nums sorted in non-decreasing order based on the mapped values of its elements.

// Notes:

// Elements with the same mapped values should appear in the same relative order as in the input.
// The elements of nums should only be sorted based on their mapped values and not be replaced by them.
Dictionary<int,int> dict;
Dictionary<int,int> dict2;

public int[] SortJumbled(int[] mapping, int[] nums) {
    dict = new();
    dict2 = new();
    for(int i=0;i<10;i++) dict[i]=mapping[i];
    Array.Sort(nums,(x,y)=>MySort(x,y));
    return nums;
}   

int MySort(int x,int y){
    int a,b;
    if(dict2.ContainsKey(x)) a=dict2[x];
    else {
        a =MyConvert(x);
        dict2[x] = a;
    }
    if(dict2.ContainsKey(y)) b=dict2[y];
    else {
        b =MyConvert(y);
        dict2[y] = b;
    }
    if(a>b) return 1;
    if(a<b) return -1;
    else return 0;
}

int MyConvert(int x){
    StringBuilder converted = new();
    string old = x.ToString();

    foreach(char c in old){
        int i = Convert.ToInt32(c.ToString());
        if(converted.ToString().Length==0 && i==0 && old.Length>1){}
        else {
            converted.Append(dict[i].ToString());
        }
    }
    string s = converted.ToString();
    if(String.IsNullOrEmpty(s)) return 0;
    return Convert.ToInt32(s);
}