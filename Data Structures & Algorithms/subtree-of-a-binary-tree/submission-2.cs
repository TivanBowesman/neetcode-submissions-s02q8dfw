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
        if (root == null) return false;

        // check if current trees are same
        if (same(root, subRoot)) return true;

        // otherwise check left and right subtrees
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public static bool same(TreeNode node, TreeNode cNode) {
        if (node == null && cNode == null) return true;
        if (node == null || cNode == null) return false;
        if (node.val != cNode.val) return false;

        return same(node.left, cNode.left) && same(node.right, cNode.right);
    }
}

