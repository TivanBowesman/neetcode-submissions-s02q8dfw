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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (!preorder.Any() || !inorder.Any()){
            return null;
        }
        var root = new TreeNode(preorder[0]);

        var node = root;
        
        int mid = Array.IndexOf(inorder, root.val);

        node.left = BuildTree(preorder[1..(mid + 1)], inorder[..mid]);
        node.right = BuildTree(preorder[(mid + 1)..], inorder[(mid + 1)..]);


        return root;
    }

    
}
