public bool HasCycle(ListNode head) {
        if (head == null) return false;

            while (head != null)
            {
                if (head.val == Int32.MaxValue) return true;

                head.val = Int32.MaxValue;
                head = head.next;
            }

            return false;
}