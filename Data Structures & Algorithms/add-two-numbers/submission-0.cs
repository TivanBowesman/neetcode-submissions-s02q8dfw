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

//add l1 and l2 vals
//place ans value list in reverse order
//list to int 
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var dummy = new ListNode(0);
        var current = dummy;
        var carry = 0;

        while (l1 != null || l2 != null|| carry != 0) {// OR statements
            int val1 = (l1 != null) ? l1.val : 0; // True : False
            int val2 = (l2 != null) ? l2.val : 0;

            int sum = val1 + val2 + carry;
            carry = sum / 10;

            current.next = new ListNode(sum%10);
            current = current.next;

            if(!(l1 is null)) l1 = l1.next;
            if(!(l2 is null)) l2 = l2.next;

            
        }
        return dummy.next;
    }
}
