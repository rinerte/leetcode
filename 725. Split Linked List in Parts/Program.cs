public ListNode[] SplitListToParts(ListNode head, int k) {
    ListNode[] list = new ListNode[k];
    ListNode[] listHeads = new ListNode[k];

    ListNode dummy = head;
    int count = 0;

    while (head != null)
    {
        count++;
        head = head.next;
    }

    int offset = count % k;
    int maxElements = count / k;
    int currentIndex = 0;

    head = dummy;
    count = 0;

    while (head != null)
    {
        if (currentIndex == k) currentIndex = 0;

        if (list[currentIndex] == null)
        {
            list[currentIndex] = new(head.val);
            listHeads[currentIndex] = list[currentIndex];
        }
        else
        {
            list[currentIndex].next = new(head.val);
            list[currentIndex] = list[currentIndex].next;
        }
        count++;
        if (count >= (offset > 0 ? maxElements + 1 : maxElements))
        {
            if (count >= maxElements + 1)
            {
                offset--;
            }
            currentIndex++;
            count = 0;
        }
        head = head.next;
    }

    return listHeads;
}