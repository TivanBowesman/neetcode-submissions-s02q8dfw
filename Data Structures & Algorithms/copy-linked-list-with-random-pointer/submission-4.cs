/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        //map new nodes to old nodes 
        if (head is null) return head;
        
        var node = head;
        var map = new Dictionary<Node,Node>();
        while(node != null){
            //map old to new copy
            map[node] = new Node(node.val);

            node = node.next;
            
        }
        
        node = head;
        //link the random pointers
        while(node != null){
            if(node.next != null){
                map[node].next = map[node.next];
            }
            if(node.random != null){
                map[node].random = map[node.random];
            }
            

            node = node.next;
        }

        return map[head];
    }
}
