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
        //implement stack 
        var stack = new Stack<Tuple<TreeNode,int>>();
        int maxDepth = 0;
        //push node into stack
        stack.Push(new Tuple<TreeNode,int>(root,1));

        while (stack.Count > 0){
            var current = stack.Pop();
            var Node = current.Item1;
            var num = current.Item2;

            if (Node != null){
                maxDepth = Math.Max(maxDepth, num);
                stack.Push(new Tuple<TreeNode,int>(Node.left,num+1));
                stack.Push(new Tuple<TreeNode,int>(Node.right,num+1));
            }
        }

        return maxDepth;
    }
}
