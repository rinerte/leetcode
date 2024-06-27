public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> visited = new HashSet<ListNode>();
            while (headA != null)
            {
                visited.Add(headA);
                headA = headA.next;
            }
            while(headB != null)
            {
                if(visited.Contains(headB)) return headB;
                headB = headB.next;
            }
            return null;
    }