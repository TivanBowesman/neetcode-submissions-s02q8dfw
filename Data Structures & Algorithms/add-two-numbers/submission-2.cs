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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0);
        int carry = 0;
        var node = dummy;

        while(l1 != null || l2 != null || carry != 0 ){
            int curr = carry; 

            if(l1 != null){
                curr += l1.val;
                l1 = l1.next;
            }
            if (l2 != null){
                curr += l2.val;
                l2 = l2.next;
            }
            carry = curr / 10 ;
            node.next = new ListNode(curr % 10);
            node = node.next;
        }

        return dummy.next;
    }
}
