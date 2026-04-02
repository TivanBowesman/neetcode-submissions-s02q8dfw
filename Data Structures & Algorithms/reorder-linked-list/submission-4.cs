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
        if(head.next is null) return ;

        //list of nodes in head; 
        var list = new List<ListNode>(); 

        var node = head; 
        while(node != null){
            list.Add(node);

            node = node.next;
        }

        node = head; // reset 
        var len = list.Count;


        var order = new List<ListNode>();
        int l = 0, r = len - 1;
        while (l <= r) {
            if (l == r) order.Add(list[l]);
            else {
                order.Add(list[l]);
                order.Add(list[r]);
            }
            l++;
            r--;
        }

        // Rewire next pointers
        for(int i = 0; i < order.Count - 1; i++){
            order[i].next = order[i + 1];
        }
        order[^1].next = null;


 
    }
}
