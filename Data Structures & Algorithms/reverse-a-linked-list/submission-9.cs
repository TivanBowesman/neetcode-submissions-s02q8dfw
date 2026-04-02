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
        if (head is null) return head; 

        ListNode prev = null;

        var node = head;
        while(node != null){
            var temp = node.next; 
    // prev 1, 2, 3, 4
//        node,temp 
//      node.next = prev
//      prev = node


            node.next = prev;
            prev = node; 
            node = temp;

        }

        return prev;
    }
}
