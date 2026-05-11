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

        var dummy = new ListNode(); 

        var head = dummy;
        while(list1 != null && list2 != null){
            //conmpare vals
            if(list1.val <= list2.val){
                head.next  = list1;
                list1 = list1.next;
            }else{
                head.next = list2;
                list2 = list2.next;
            }

            head = head.next; 
        }

        //check for empty list
        if(list1 is null){
            head.next = list2;
        }else{
            head.next = list1;
        }

        return dummy.next; 
    }
}