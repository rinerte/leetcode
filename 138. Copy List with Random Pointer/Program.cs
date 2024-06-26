public Node CopyRandomList(Node head) {
        if(head == null) return null;

            Dictionary<Node, Node> mapping = new Dictionary<Node, Node>();

            Node current = head;
            while (current != null)
            {
                mapping[current] = new(current.val);
                current = current.next;
            }
            current = head;

            while(current != null)
            {
                mapping[current].next = current.next != null ? mapping[current.next] : null;
                mapping[current].random = current.random != null ? mapping[current.random] : null;
                current = current.next;
            }

            return mapping[head];
}