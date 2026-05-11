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
    bool check;
    public bool IsBalanced(TreeNode root) {
        if (root is null) return true;
        check = true;
        dfs(root);
        return check;
    }

    public int dfs(TreeNode root){
        if (root is null) return 0;

        var left = dfs(root.left);
        var right = dfs(root.right);

        if(Math.Abs(left - right) > 1) check = false;

        return 1 + Math.Max(left, right);

        
    }
}
