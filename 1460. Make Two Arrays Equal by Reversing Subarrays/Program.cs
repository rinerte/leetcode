//You are given two integer arrays of equal length target and arr. In one step, you can select any non-empty subarray of arr and reverse it. You are allowed to make any number of steps.

//Return true if you can make arr equal to target or false otherwise.
public bool CanBeEqual(int[] target, int[] arr)
{
    Dictionary<int, int> d = new();
    for (int i = 0; i < target.Length; i++)
    {
        if (d.ContainsKey(target[i]))
        {
            d[target[i]]++;
        }
        else d[target[i]] = 1;
        if (d.ContainsKey(arr[i]))
        {
            d[arr[i]]--;
        }
        else d[arr[i]] = -1;
    }
    return d.Values.Where(i => i != 0).Count() == 0;
}