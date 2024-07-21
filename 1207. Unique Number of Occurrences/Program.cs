//Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.
public bool UniqueOccurrences(int[] arr)
{
    Dictionary<int, int> d = new();
    foreach (int i in arr)
    {
        if (d.ContainsKey(i)) d[i]++;
        else d[i] = 1;
    }
    HashSet<int> hash = new();
    foreach (int i in d.Values)
    {
        if (hash.Contains(i)) return false;
        hash.Add(i);
    }
    return true;
}