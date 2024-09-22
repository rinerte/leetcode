// You are given the head of a linked list, which contains a series of integers separated by 0's. The beginning and end of the linked list will have Node.val == 0.

// For every two consecutive 0's, merge all the nodes lying in between them into a single node whose value is the sum of all the merged nodes. The modified list should not contain any 0's.

// Return the head of the modified linked list.

public ListNode MergeNodes(ListNode head) {
        
    var current = new ListNode(0, null);
    var dummy = current;

    int sum = 0;

    while(head!=null || sum>0){
        if((int)head?.val==0){
            if(sum>0){
                current.next = new(sum,null);
                current = current.next;
            }
            head = head.next;
            sum = 0;
        } else {
            sum+=head.val;
            head = head.next;
        }
    }
    return dummy.next;
}