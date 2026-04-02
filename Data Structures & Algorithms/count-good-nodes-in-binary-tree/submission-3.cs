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
        return dfs(root,root.val);
    }
    
    public int dfs(TreeNode node, int max){
        if (node is null ) return 0;
        //keep track of max at each level
        int biggest = max;

        int good = 0;
        if (node.val >= max){ //bigger or equal to prev node
            good++;
        }

        biggest = Math.Max(biggest, node.val);
        good += dfs(node.left,biggest);
        good += dfs(node.right,biggest);

        return good;
    }
}
