/*
// Definition for a Node.
public class Node {
    public int _val;
    public Node next;
    public Node random;
    
    public Node(int val) {
        _val = val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head is null) return null;
        //has random poinyer
        //create new nodes
        var map = new Dictionary<Node, Node>(); // node -> randomnode

        var node = head;
        while(node != null){
            
            map[node] = new Node(node.val);
            
            node = node.next;
        }

        node = head;

        while(node != null){
            //assign next 
            if(node.next != null){
                map[node].next = map[node.next];
            }
            //assign random
            if(node.random != null){
                map[node].random = map[node.random];
            }
            

            node = node.next;
        }


        return map[head];
    }
}
