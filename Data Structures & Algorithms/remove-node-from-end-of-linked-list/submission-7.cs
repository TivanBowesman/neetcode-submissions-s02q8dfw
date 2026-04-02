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
        if (head is null) return head;

        var length = 0; 
        var node = head;
        //find length 
        while(node != null){
            length++;
            node = node.next; 
        }

        //check if node to be skipped is at beginning
        if (length - n == 0 ) return head.next;

        //reset node
        node = head;

        for(int i = 0; i < length - 1; i++){
            if(i+1 == length - n){
                //skip node
                node.next = node.next.next; 
                break; 
            }
            
            node = node.next; 
        }


        return head;
    }
}
