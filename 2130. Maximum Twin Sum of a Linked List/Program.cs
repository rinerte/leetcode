// In a linked list of size n, where n is even, the ith node (0-indexed) of the linked list is known as the twin of the (n-1-i)th node, if 0 <= i <= (n / 2) - 1.

// For example, if n = 4, then node 0 is the twin of node 3, and node 1 is the twin of node 2. These are the only nodes with twins for n = 4.
// The twin sum is defined as the sum of a node and its twin.

// Given the head of a linked list with even length, return the maximum twin sum of the linked list.
public int PairSum(ListNode head) {        
    int max =0;
    int count =0;
    int length = 32;
    int[] array = new int[length];

    while(head!=null){
        if(count>length-1){
            var temp = array;
            array = new int[length*2];
            Array.Copy(temp,array,length);
            length*=2;
        }
        array[count] = head.val;
        head = head.next;
        count++;
    }
    for(int i=0;i<count/2;i++){
        if(array[i]+array[count-1-i]>max) max = array[i]+array[count-1-i];
    }
    return max;
}