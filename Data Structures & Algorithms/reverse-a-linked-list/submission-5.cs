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
    public ListNode ReverseList(ListNode head) {
        // point the ListNode objects to the previous node
        ListNode prev = null;
        ListNode current = head; //starts at the beginning of input array

        while (current != null){
            //get the next value to keep place
            ListNode next = current.next;

            current.next = prev;
            //move pointers along
            prev = current; 
            current = next;
        }

        return prev;
    }
}
