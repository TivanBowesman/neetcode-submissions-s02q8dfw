/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;

 *     public ListNode(int val=0, ListNode next=null) (0,null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

//store in hashmap (index, listnode)
//if list node appears in the value more than once return false
//hashset to store node? (can directly return false) hashset stores the next node

public class Solution {
    public bool HasCycle(ListNode head) {
        head = head.next;
        var hashset = new HashSet<ListNode>();
        while (head != null){
            //add next to hashset
            if (!hashset.Add(head.next)){
                //means hash has a cycle
                return true;
            }
            //move position
            head = head.next;
        }
        return false;
    }
}
