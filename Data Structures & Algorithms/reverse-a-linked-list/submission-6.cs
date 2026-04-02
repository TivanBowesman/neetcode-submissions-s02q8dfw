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
        //node at the beginning that is null
        ListNode prev = null;
        var node = head;
        
        while (node != null){
            var temp = node.next; 

            //swaps
            node.next = prev;
            prev = node;
            node = temp;

        }
        return prev;
    }
}
