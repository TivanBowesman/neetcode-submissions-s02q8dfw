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
        var node = head;

        int len = 0;
        while(node != null){
            len++;
            node = node.next; 
        }
        Console.WriteLine(len );
        //check if node to be skipped is at beginning
        if (len - n == 0 ) return head.next;

        //go to pos for removal
        node = head;
        for(int i = 0; i < len - n - 1 ; i++){
            node = node.next;
        }

        node.next = node.next.next;

        return head;
    }
}
