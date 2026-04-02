/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root) {
        var stack = new Stack<Tuple<TreeNode,int>>();
        //visit child nodes 
        //append to stack if the node has children
        //pop if parent has no more child nodes 
        //store the count of max depth in a variable
        int CurrentMax = 0;
        
        //push root node onto stack
        stack.Push(new Tuple<TreeNode,int>(root,1));

        //while stack is not empty 
        while (stack.Count > 0){
            var current = stack.Pop();
            //access the root and depth through item1 and item2
            TreeNode node = current.Item1;
            int depth = current.Item2;

            //append to stack if root is not null
            //change max if node is not null
            if (node != null){
                CurrentMax = Math.Max(CurrentMax,depth);
                stack.Push(new Tuple<TreeNode,int>(node.left,depth + 1));
                stack.Push(new Tuple<TreeNode,int>(node.right,depth + 1));
            }
        }
        return CurrentMax;
    }
}
