// Given the head of a linked list head, in which each node contains an integer value.

// Between every pair of adjacent nodes, insert a new node with a value equal to the greatest common divisor of them.

// Return the linked list after insertion.

// The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        var dummy = head;
        while(head!=null && head.next!=null){
           
            head.next = new(GCD(head.val,head.next.val),head.next);
            head = head.next.next;
        }
        return dummy;
    }

    int GCD(int a, int b)
    {
       return a==0?b:GCD(Math.Max(a,b)%Math.Min(a,b),Math.Min(a,b));
    }
}