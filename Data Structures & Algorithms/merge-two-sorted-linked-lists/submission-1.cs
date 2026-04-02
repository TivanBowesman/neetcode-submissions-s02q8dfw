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
        //edge case if either list is null
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        var placeholder = new ListNode(); // intialised as (0,null)
        var current = placeholder;

        while (list1 != null && list2 != null){
            
            if (list1.val < list2.val){
                current.next = list1;
                //move l1
                list1 = list1.next;
            }else if(list1.val > list2.val){
                current.next = list2;
                list2 = list2.next;
            }else{ //assumes both are equal here
                current.next = list2;
                list2 = list2.next;
            }
            //move the (imaginary)pointer to the next postion 
            current = current.next;
            
        }
        // append the other list depending on which is null
        if (list1 == null){
            current.next = list2;
        }else{
            current.next = list1;
        }

        //return the placeholder list 
        return placeholder.next;
    }
}