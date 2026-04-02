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
    public bool HasCycle(ListNode head) {
        ListNode slow = head, fast = head;

        //if any become null it means that there is no cycle 
        while (fast != null && fast.next != null){
            fast = fast.next.next; // have pointer move twice as fast
            slow = slow.next;

            if(slow.Equals(fast)){
                return true;
            }
        }
        return false;
    }
}
