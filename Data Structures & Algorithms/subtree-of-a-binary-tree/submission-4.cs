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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        //check against other nodes
        if (root is null ) return false;

        if(same(root, subRoot)) return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        
    }

    public bool same(TreeNode node, TreeNode node2){
        if(node is null && node2 is null) return true;

        if(node is null || node2 is null) return false;

        if(node.val != node2.val) return false;

        return same(node.left, node2.left) && same(node.right, node2.right);
    }
}
