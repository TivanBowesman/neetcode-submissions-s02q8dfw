/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null ) return null; 

        //first create nodes by going over the nodes in a dfs
        //map nodes to new nodes
        var map = new Dictionary<Node,Node>(); //old node -> new node
        var stack = new Stack<Node>();
        stack.Push(node);

        var visited = new HashSet<Node>();

        while (stack.Any()){
            var item = stack.Pop();
            //create new node that has the same val as old node
            map[item] = new Node(item.val);

            //add neigbours to the stack.
            foreach(var i in item.neighbors){
                if(!visited.Contains(i)){
                    visited.Add(i);
                    stack.Push(i);
                }
            }
        }

        //go over the key values pairs in the map
        foreach(var i in map.Keys){
            //each node in the old map
            foreach(var j in i.neighbors){
                //add the neigbours to the new map
                map[i].neighbors.Add(map[j]);
            }
        }

        return map[node];

    }
}
