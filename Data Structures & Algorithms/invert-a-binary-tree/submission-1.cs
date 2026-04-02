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
    public TreeNode InvertTree(TreeNode root) {
        //edge case
        if (root is null) return null;
        
        //stack for DFS
        var stack = new Stack<TreeNode>();
        //push root into stack
        stack.Push(root);

        while( stack.Count > 0){
            var current = stack.Pop();

            var temp = current.left;
            current.left = current.right;
            current.right = temp;

            //push onto the stack so that it can be prepped for reversal
            if (current.left != null) stack.Push(current.left);
            if (current.right != null) stack.Push(current.right); 
        }

        return root;

    }
}
