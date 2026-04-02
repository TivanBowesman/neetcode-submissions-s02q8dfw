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
        //edge case 
        if (list1 is null ) return list2;
        if (list2 is null ) return list1; 

        //return the head of the list node 
        ListNode node = new ListNode();
        ListNode current = node;
        
        while (list1 != null && list2 != null){
            // 
            Console.WriteLine(current.val);
            if (list1.val < list2.val){
                current.next = list1;
                list1 = list1.next; 
            }else if (list2.val < list1.val){
                current.next  = list2; 
                list2 = list2.next; 
            }else{ // equal
                current.next = list1;
                list1 = list1.next;
            }
            current = current.next;
        }

        if (list1 is null ){
            current.next = list2;
        }else{
            current.next = list1;
        }
        
        return node.next;
    }
}