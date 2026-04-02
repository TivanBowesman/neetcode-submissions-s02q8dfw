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
//we're reversing the linked list *NOT* just finding the next head
public class Solution {
    public ListNode ReverseList(ListNode head) {
        //node ahead of the original Linked List
        ListNode p = null;
        ListNode c = head; //c has data for the next method. (head is simply the first element in the presented array)

        while (c != null){
            ListNode temp = c.next;
            //next node is the previous one
            c.next = p;
            p = c;
            c = temp;
        }
        return p;        
    }
}
