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
    public void ReorderList(ListNode head) {
        //[0, n-1, 1, n-2, 2, n-3, ...]
        //use map to get node and its index - change its next

        var map = new Dictionary<int, ListNode>(); 
        var node = head;
        int index = 0;
        while(node != null){
            map[index] = node; 
            node = node.next;
            index++;
        }

        int i = 0;
        int j = index - 1;
        

        while (i < j) {
            map[i].next = map[j];
            map[j].next = map[i + 1];
            i++;
            j--;
        }

        map[i].next = null;

    }
}
