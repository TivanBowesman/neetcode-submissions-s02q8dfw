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
    public int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        diameter = 0;

        dfs(root);
        return diameter;
    }

    public int dfs(TreeNode root) {
        if (root is null)
            return 0;

        var left = dfs(root.left);
        var right = dfs(root.right);

        diameter = Math.Max(diameter, left + right);

        return 1 + Math.Max(left, right);
    }
}
