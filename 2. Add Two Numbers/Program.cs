public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode current = new(0);
            ListNode Head = new(0, current);

            int next = 0;

            while (l1 != null || l2 != null)
            {
                int x = l1?.val ?? 0;
                int y = l2?.val ?? 0;

                current.val = x + y + next;

                if (current.val >= 10)
                {
                    current.val = current.val - 10;
                    next = 1;
                }
                else
                {
                    next = 0;
                }


                l1 = l1?.next;
                l2 = l2?.next;

                if (l1 != null || l2 != null || next > 0)
                {
                    current.next = new(0 + next);
                    current = current.next;
                }

            }


            return Head.next;
}