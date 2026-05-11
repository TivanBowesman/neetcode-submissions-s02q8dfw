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
        return dfs(p, q);
    }

    public bool dfs(TreeNode p, TreeNode q){
        if(p is null && q is null){
            return true;
        }else if (p is null || q is null){
            return false;
        }

        //compare val
        if(q.val != p.val ) return false;

        //check other values
        return dfs(p.left, q.left) && dfs(p.right, q.right);
    }
}
