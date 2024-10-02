// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// // Given an array of integers arr, replace each element with its rank.

// // The rank represents how large the element is. The rank has the following rules:

// // Rank is an integer starting from 1.
// // The larger the element, the larger the rank. If two elements are equal, their rank must be the same.
// // Rank should be as small as possible.
// public class Solution {
//     public int[] ArrayRankTransform(int[] arr) {
//         int rank = 1;
//         int last = int.MaxValue;
//         var toCheck = Enumerable.Range(0, arr.Length).ToList();
        
//         while(toCheck.Any()){
//             int minIndex = 0;
//             int min = int.MaxValue;
//             foreach(int index in toCheck){
//                 if(arr[index]<=min){
//                      minIndex = index;
//                      min = arr[index];
//                 }
//             }
//             if(arr[minIndex]>last)rank++;
//             last = arr[minIndex];
//             arr[minIndex] = rank;            
//             toCheck.Remove(minIndex);
//         }
//         return arr;
//     }
// }
public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var rank = new Dictionary<int, int>();

        foreach (var a in arr.Order())
            rank.TryAdd(a, rank.Count + 1);

        return Array.ConvertAll(arr, a => rank[a]);
    }
}