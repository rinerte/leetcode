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