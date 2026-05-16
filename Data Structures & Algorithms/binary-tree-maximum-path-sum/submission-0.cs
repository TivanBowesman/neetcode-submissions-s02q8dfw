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
    int max;
    public int MaxPathSum(TreeNode root) {
        max = root.val; 

        helper(root); 

        return max;
    }

    public int helper(TreeNode root){
        if (root is null) return 0;

        int left = Math.Max(helper(root.left), 0);
        int right = Math.Max(helper(root.right), 0);

        max = Math.Max(max, root.val + left + right);

        return root.val + Math.Max(left, right);
    }
}
