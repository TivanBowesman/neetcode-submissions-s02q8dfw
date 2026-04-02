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
        int max = 0;

        stack.Push(new Tuple<TreeNode,int>(root,1));

        while(stack.Count > 0){
            var current = stack.Pop();
            TreeNode node = current.Item1;
            int level = current.Item2;

            if (node != null ){
                
                stack.Push(new Tuple<TreeNode,int>(node.left, level + 1));
                stack.Push(new Tuple<TreeNode,int>(node.right, level + 1));
                max = Math.Max(level, max);
            }
            
        }

        return max;
    }
}
