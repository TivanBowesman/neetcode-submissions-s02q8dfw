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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //get count 
        //create new list
        // when you get to len - n , next = curr.next.next;
        var count = head;
        int length = 0;
        while (count != null){
            count = count.next;
            length++;
        }
        //second pass
        var node = head;
        int max = length;
        if (max - n == 0){
            return head.next;
        }
        
        for (int i = 0; i < max - 1; i++) {
            if (i + 1 == max - n) {
                node.next = node.next.next;
                //we can break because the next.next node knows the rest of the list 
                break;
            }
            node = node.next;
        }

        return head;
    }
}
