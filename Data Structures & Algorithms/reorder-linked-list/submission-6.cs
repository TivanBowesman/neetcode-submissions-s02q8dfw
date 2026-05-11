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
        // use map index, node
        var map = new Dictionary<int, ListNode>();
        var node = head;

        int index = 0;
        while (node != null) {
            map[index] = node;
            index++;
            node = node.next;
        }

        int i = 0;
        int j = index - 1;

        while (i < j) {
            // i -> n-1
            map[i].next = map[j];
            // n-1 -> i
            map[j].next = map[i + 1];
            j--;
            i++;
        }

        // get the last node
        map[i].next = null;
    }
}
