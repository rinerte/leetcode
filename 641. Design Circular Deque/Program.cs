//Design your implementation of the circular double-ended queue (deque).

//Implement the MyCircularDeque class:

//MyCircularDeque(int k) Initializes the deque with a maximum size of k.
//boolean insertFront() Adds an item at the front of Deque.Returns true if the operation is successful, or false otherwise.
//boolean insertLast() Adds an item at the rear of Deque.Returns true if the operation is successful, or false otherwise.
//boolean deleteFront() Deletes an item from the front of Deque.Returns true if the operation is successful, or false otherwise.
//boolean deleteLast() Deletes an item from the rear of Deque.Returns true if the operation is successful, or false otherwise.
//int getFront() Returns the front item from the Deque.Returns -1 if the deque is empty.
//int getRear() Returns the last item from Deque.Returns -1 if the deque is empty.
//boolean isEmpty() Returns true if the deque is empty, or false otherwise.
//boolean isFull() Returns true if the deque is full, or false otherwise.
public class Node
{
    public int val;
    public Node prev;
    public Node next;

    public Node(int val)
    {
        this.val = val;
        prev = null;
        next = null;
    }
}

public class MyCircularDeque
{
    private Node head = new Node(-1);
    private Node tail = new Node(-1);
    private int size;
    private int currSize;

    public MyCircularDeque(int k)
    {
        head.next = tail;
        tail.prev = head;
        size = k;
        currSize = 0;
    }

    public bool InsertFront(int value)
    {
        if (currSize == size)
            return false;

        AddNode(head, value);
        currSize++;
        return true;
    }

    public bool InsertLast(int value)
    {
        if (currSize == size)
            return false;

        AddNode(tail.prev, value);
        currSize++;
        return true;
    }

    public bool DeleteFront()
    {
        if (currSize == 0)
            return false;

        DeleteNode(head.next);
        currSize--;
        return true;
    }

    public bool DeleteLast()
    {
        if (currSize == 0)
            return false;

        DeleteNode(tail.prev);
        currSize--;
        return true;
    }

    public int GetFront()
    {
        if (currSize == 0)
            return -1;

        return head.next.val;
    }

    public int GetRear()
    {
        if (currSize == 0)
            return -1;

        return tail.prev.val;
    }

    public bool IsEmpty()
    {
        return currSize == 0;
    }

    public bool IsFull()
    {
        return currSize == size;
    }

    private void AddNode(Node head, int value)
    {
        Node after = head.next;
        Node temp = new Node(value);
        head.next = temp;
        temp.prev = head;
        temp.next = after;
        after.prev = temp;
    }

    private void DeleteNode(Node head)
    {
        Node after = head.next;
        Node before = head.prev;
        before.next = after;
        after.prev = before;
    }
}