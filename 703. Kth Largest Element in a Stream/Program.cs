// Design a class to find the kth largest element in a stream. Note that it is the kth largest element in the sorted order, not the kth distinct element.

// Implement KthLargest class:

// KthLargest(int k, int[] nums) Initializes the object with the integer k and the stream of integers nums.
// int add(int val) Appends the integer val to the stream and returns the element representing the kth largest element in the stream.
// Very SLOW solution
// public class KthLargest {
//     List<int> numsList;
//     int kk;
//     public KthLargest(int k, int[] nums) {        
//         Array.Sort(nums);
//         numsList = new(nums);
//         kk =k;
//     }
    
//     public int Add(int val) {
//         numsList.Add(val);
//         numsList.Sort();
//         return numsList[^kk];
//     }
// }
public class KthLargest {
    int[] tail;
    public KthLargest(int k, int[] nums) {    
        tail = new int[k];
        Array.Fill(tail,int.MinValue);
        Array.Sort(nums);
        for(int i=0;i<nums.Length && i<k;i++){
            tail[^(1+i)]=nums[^(1+i)];
        }
    }
    
    public int Add(int val) {
        int index = -1;
        for(int i=0;i<tail.Length;i++){
            if(val>tail[i]) index = i;
        }
        for(int i=0;i<index;i++) tail[i]=tail[i+1];
        if(index>=0)
        tail[index]=val;

        return tail[0];
    }
}