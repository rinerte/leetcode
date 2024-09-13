// You are given an array arr of positive integers. You are also given the array queries where queries[i] = [lefti, righti].

// For each query i compute the XOR of elements from lefti to righti (that is, arr[lefti] XOR arr[lefti + 1] XOR ... XOR arr[righti] ).

// Return an array answer where answer[i] is the answer to the ith query.
public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        int[] ans = new int[queries.Length];
        for(int i=0;i<queries.Length;i++){
            int res = arr[queries[i][0]];
            for(int j=queries[i][0]+1;j<=queries[i][1];j++) res^=arr[j];
            ans[i] = res;
        }
        return ans;
    }
}