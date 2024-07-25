// You are given the head of a linked list. Delete the middle node, and return the head of the modified linked list.

// The middle node of a linked list of size n is the ⌊n / 2⌋th node from the start using 0-based indexing, where ⌊x⌋ denotes the largest integer less than or equal to x.

// For n = 1, 2, 3, 4, and 5, the middle nodes are 0, 1, 1, 2, and 2, respectively.
public ListNode DeleteMiddle(ListNode head) {        
    int count = 0;
    var old = new ListNode(0,head);

    while(head!=null){
        count++;
        head = head.next;
    }
    if(count<=1) return null;
    head = old.next;
    for(int i=0;i<count/2-1;i++){
        head = head.next;
    }
    head.next = head.next?.next;
    return old.next;
}