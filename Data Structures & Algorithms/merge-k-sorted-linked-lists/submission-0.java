/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */

class Solution {
    public ListNode mergeKLists(ListNode[] lists) {
        //get the node
        //use max heap to assign val 

        PriorityQueue<ListNode> maxHeap = new PriorityQueue<>(
            (a,b) -> Integer.compare(b.val, a.val)
        );

        for(ListNode node : lists){
            while(node != null){
                maxHeap.add(node);
                node = node.next;
            }
        }

        ListNode prev = null;

        while(!maxHeap.isEmpty()){
            var node = maxHeap.poll();

            node.next = prev;
            prev = node; 
        }

        return prev; 
    }
}
