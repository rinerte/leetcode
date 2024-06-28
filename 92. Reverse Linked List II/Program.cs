public ListNode ReverseBetween(ListNode head, int left, int right) {
    int count = 1;
    ListNode headPointer = head;
    ListNode first=head, last = head.next;
    Stack<ListNode> stack = new Stack<ListNode>();

    if (head == null || left == right) return head;

    ListNode dummyHead = new ListNode(0);
    dummyHead.next = head;
    ListNode previous = dummyHead;

    for (int i = 0; i < left - 1; i++)
    {
        previous = previous.next;
    }

    ListNode current = previous.next;

    for (int i = 0; i < right - left; i++)
    {
        ListNode nextNode = current.next;
        current.next = nextNode.next;
        nextNode.next = previous.next;
        previous.next = nextNode;
    }

    return dummyHead.next;
}