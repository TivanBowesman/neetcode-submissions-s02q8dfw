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
        if (head is null) return null; 
        //make use of hashmap (dictionary)
        //old node maps to the new node

        //create the nodes then assign the next and random pointers
        var map = new Dictionary<Node,Node>();
        var current = head; 

        while (current != null){
            //populate the hashmap 
            map[current] = new Node(current.val);
            current = current.next; 
        }

        //assign next and random 
        current = head;
        while (current != null){
            var node = map[current];

            if (current.next != null ){
                node.next = map[current.next];
            }else{
                node.next = null;
            }
            if (current.random != null){
                node.random = map[current.random];
            }else{
                node.random = null;
            }


            current = current.next;
        }
        
        return map[head];

    }
}
