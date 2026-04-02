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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var node = root;

        while(node != null){
            //if split node is LCA
            if(p.val < node.val && q.val < node.val){
                //move to left subtree
                node = node.left; 
            }else if (p.val > node.val && q.val > node.val){
                //move to right subtree
                node = node.right; 
            }else{
                //split or p/q is found
                return node; 
            }
        }
        return node;
    }
}
