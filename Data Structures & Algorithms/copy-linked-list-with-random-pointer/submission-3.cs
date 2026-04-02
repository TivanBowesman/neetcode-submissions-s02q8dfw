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
        if(head is null )return head; 
        var map = new Dictionary<Node,Node>();

        //populate with old data(node, new node)
        var node = head; 
        while(node != null){
            map[node] = new Node(node.val) ;
            node = node.next; 
        }

        //create new nodes
        node = head;

        while(node != null){
            var copy = map[node];

            if(node.next != null){
                copy.next = map[node.next];
            }else{
                copy.next = null;
            }

            if(node.random != null){
                copy.random = map[node.random];
            }else{
                copy.random = null;
            }

            node = node.next;
        }
        return map[head];
    }
}
