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
        //if there is a split the from the current node, return the current node

        TreeNode node =  root;
        while(node != null){
            if(p.val > node.val && q.val > node.val){ //both are bigger
                node = node.right;
            }else if(p.val < node.val && q.val < node.val){ //both are smaller
                node = node.left;
            }else{//there must be a split 
                return node;
            }
        }
        return node; 
    }
}
