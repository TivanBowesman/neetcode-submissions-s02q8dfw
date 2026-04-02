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

        return dfs(p,q);
    
    }

    public bool dfs(TreeNode node1, TreeNode node2){
        if(node1 is null && node2 is null) return true;
        if(node1 is null && node2 != null) return false; 
        if(node2 is null && node1 != null) return false;

        
        var val1 = node1.val; 
        var val2 = node2.val;

        if(val1 != val2) return false;

        return dfs(node1.left,node2.left) && dfs(node1.right,node2.right);
    }
}
