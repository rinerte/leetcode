// You are given a string word containing lowercase English letters.

// Telephone keypads have keys mapped with distinct collections of lowercase English letters, which can be used to form words by pushing them. For example, the key 2 is mapped with ["a","b","c"], we need to push the key one time to type "a", two times to type "b", and three times to type "c" .

// It is allowed to remap the keys numbered 2 to 9 to distinct collections of letters. The keys can be remapped to any amount of letters, but each letter must be mapped to exactly one key. You need to find the minimum number of times the keys will be pushed to type the string word.

// Return the minimum number of pushes needed to type word after remapping the keys.

// An example mapping of letters to keys on a telephone keypad is given below. Note that 1, *, #, and 0 do not map to any letters.
Dictionary<char,int> frequency;
public int MinimumPushes(string word) {
    frequency = new();
    foreach(char a in word){
        if(frequency.ContainsKey(a)) frequency[a]++;
        else frequency[a]=1;
    }
    char[] arr = word.ToCharArray();
    Array.Sort(arr, (a,b)=>Compare(a,b));

    Dictionary<char,int> positions = new();

    int empty = 8;
    int increment = 0;
    int count =0;
    foreach(char a in arr){
        if(positions.ContainsKey(a)){
            count+=positions[a];
        } else
        {
            positions[a] = 1 + increment;
            count+=positions[a];
            empty--;
            if(empty==0){
                empty = 8;
                increment++;
            }             
        }
    }
    return count;
}
int Compare(char x, char y){
    if(frequency[x]>frequency[y]) return -1;
    if(frequency[x]<frequency[y]) return 1;
    else return 0;
}