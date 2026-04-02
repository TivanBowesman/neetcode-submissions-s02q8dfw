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
        if (head is null ) return head;

        //find the length of the linked list
        int length = 0;
        var node = head;
        while(node != null){
            length++;
            node = node.next; 
        }

        

        //reset node
        node = head; 

        int move = length - n; 
        //check if its at the beginning
        if (move == 0) return head.next;

        for(int i = 0; i < length - 1; i++){
            if(i + 1 == move){
                node.next = node.next.next;

                break;
            }
            node = node.next;
        }


        //return head of adjusted linked list

        return head;
    }
}
