// You are given an array of integers nums and the head of a linked list. Return the head of the modified linked list after removing all nodes from the linked list that have a value that exists in nums.
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head) {
        HashSet<int> hash = new(nums);
        var newHead = new ListNode(-1,null);
        var dummy = newHead;
        while(head!=null){
            if(!hash.Contains(head.val)){
                newHead.next = new(head.val);
                newHead.next = head;
                newHead = newHead.next;
            }
            head = head.next;
        }
        return dummy.next;
    }
}