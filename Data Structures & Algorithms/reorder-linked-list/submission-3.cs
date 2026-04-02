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
        //use temp to store the swapped node

        //use list to get the node of each index
        List<ListNode> list = new List<ListNode>();
        var listadd = head;
        while (listadd != null){
            list.Add(listadd);
            listadd = listadd.next;
        }

        int l = 0;
        int r = list.Count - 1;// end of list
        while (l < r) {
            list[l].next = list[r];   
            l++;
            if (l == r) break;       // if i meet j in the middle 
            list[r].next = list[l];   
            r--;
        }
        list[l].next = null;
    }
}
