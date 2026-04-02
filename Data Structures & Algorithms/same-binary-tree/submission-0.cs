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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // if both false;
        if (p is null && q is null) return true;
        // if one if false
        if ((p == null && q!=null) || (q is null && p!= null)) return false;
        //value comaprisson

        if(p.val != q.val ){
            return false;
        }

        //call recusrsively
        return IsSameTree(p.left, q.left) && IsSameTree(p.right,q.right);


    }
}
