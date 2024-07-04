// Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

// In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
public IList<int> GetRow(int rowIndex) {
        int[] arr = new int[rowIndex+1];
        int[] temp = new int[arr.Length];

        for(int i=0;i<arr.Length;i++){
            Array.Copy(arr,temp,arr.Length);
            for(int j=0;j<=i;j++){
                if(j==0 || i==j) temp[j]=1;
                else
                temp[j]=arr[j-1]+arr[j];
            }
            Array.Copy(temp,arr,arr.Length);
        }
        return arr;
    }