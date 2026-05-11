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
        if (root is null) return false;
        //if the root of sub is root then check 
        //otherwise check for other starting points
        if (root.val == subRoot.val){
            var res = dfs(root, subRoot);
            if (res) return true;
        }

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
    public bool dfs(TreeNode root, TreeNode subroot){
        if (root is null && subroot is null) return true;

        if (root is null || subroot is null) return false;

        //should both not null here
        if (root.val != subroot.val) {
            return false;
        }

        return dfs(root.left, subroot.left) && dfs(root.right, subroot.right);
        
    }
}
