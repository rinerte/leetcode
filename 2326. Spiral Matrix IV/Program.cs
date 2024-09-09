// You are given two integers m and n, which represent the dimensions of a matrix.

// You are also given the head of a linked list of integers.

// Generate an m x n matrix that contains the integers in the linked list presented in spiral order (clockwise), starting from the top-left of the matrix. If there are remaining empty spaces, fill them with -1.

// Return the generated matrix.
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
    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        int[][] result = new int[m][];
        for(int i=0;i<m;i++) result[i] = new int[n];

        int top=-1; int bottom=m; int right=n; int left =-1;
        int direction =0;
        (int x, int y) position = (0,0);

        for(int i=0;i<m*n;i++){       
            result[position.y][position.x] = head?.val ?? -1;
            if(head!=null) head=head.next;

            switch(direction%4){
                case 0:
                    if(position.x==right-1){ direction++; top++;}
                break;
                case 1:
                    if(position.y==bottom-1) { direction++; right--;}
                break;
                case 2:
                    if(position.x==left+1) { direction++; bottom--;}
                break;
                case 3:
                    if(position.y==top+1) { direction++; left++;}
                break;
            }
            switch(direction%4){
                case 0:
                    position.x++;
                break;
                case 1:
                    position.y++;
                break;
                case 2:
                    position.x--;
                break;
                case 3:
                    position.y--;
                break;
            }
        }
        return result;
    }
}