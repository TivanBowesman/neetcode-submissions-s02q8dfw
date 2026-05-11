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
        // lca appears when there is a split in the array
        
        while(root != null){
            if(p.val < root.val && q.val < root.val){
                root = root.left;
            }else if (p.val > root.val && q.val > root.val){
                root = root.right;
            }else{
                // split 
                return root;
            }
        }

        return null;
    }
}
