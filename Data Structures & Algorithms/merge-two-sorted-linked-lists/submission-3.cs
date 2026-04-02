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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        //edge 
        if(list1 is null ) return list2;
        if(list2 is null ) return list1;
        
        var dummy = new ListNode(); 
        //pointers
        var current = dummy;
        var node1 = list1; 
        var node2 = list2;

        while(node1 != null && node2 != null){

            if (node1.val <= node2.val){
                current.next = node1;
                node1 = node1.next;
            }else{
                current.next = node2;
                node2 = node2.next;
            }

            current = current.next;
        }

        if(node1 is null) {
            current.next = node2;
        }else{
            current.next = node1;
        }
        
        return dummy.next;

 
    }
}