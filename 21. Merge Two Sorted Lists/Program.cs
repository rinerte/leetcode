public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode head = null;
    ListNode tHead = null;

    while(list1!=null || list2!=null) {
        var t = Take(ref list1, ref list2);
        if(t==null) return null;

        if(head==null){
            head = new((int)t,null);
            tHead = head;
        } else head.val = (int)t;
        
        if(list1!=null || list2!=null){
            head.next = new ListNode(0,null);
            head = head.next;
        }
    }

    return tHead;
}

public int? Take(ref ListNode list1, ref ListNode list2){
    int? t = null;
    if(list1!=null && list2!=null){        
        if(list1.val<=list2.val){
            t = list1.val;
            list1 = list1.next;
        } else
        {
            t = list2.val;
            list2 = list2.next;
        }        
    } else if(list1!=null){
        t = list1.val;
        list1 = list1.next;
    } else {
        t = list2?.val;
        list2 = list2.next;
    }
    return t;
}