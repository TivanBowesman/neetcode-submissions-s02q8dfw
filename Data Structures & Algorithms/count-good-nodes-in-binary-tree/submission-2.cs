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
    
    public int GoodNodes(TreeNode root) {
        
        return Dfs(root, root.val);
    }
    public int Dfs (TreeNode node, int max){
        if (node is null) return 0;
        int Good;

        if (node.val >= max){
            Good = 1;
        }else {
            Good = 0;
        }
        max = Math.Max(node.val, max);

        Good += Dfs(node.left, max);
        Good += Dfs(node.right, max);

        return Good;
    }
}
