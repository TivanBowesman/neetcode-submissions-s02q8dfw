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
        //p c n 
        ListNode prev = null;

        var node = head;
        while (node != null){
            var next = node.next; 
            
            //point node to prev node
            node.next = prev;
            //update prev
            prev = node;
            //move node to next node
            node = next;

        }

        return prev;
    }
}
