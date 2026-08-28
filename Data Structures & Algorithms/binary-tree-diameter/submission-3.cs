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
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        helper(root);

        return max;
    }
    //longest path between two nodes
    //get sum of both left and right
    public int helper(TreeNode root){
        if(root is null) return 0;

        int left = helper(root.left);
        int right = helper(root.right);

        max = Math.Max(left + right, max);

        return 1 + Math.Max(left, right);
    }
}
