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
    public bool ans ;
    public bool IsBalanced(TreeNode root) {
        //abs(r-l ) < 1

        ans = true;
        func(root);
        return ans;



    }
    public int func(TreeNode root){
        if (root is null) return 0;

        int left = func(root.left);
        int right = func(root.right);

        if (Math.Abs(right - left ) > 1){
            ans = false;
        }

        return 1 + Math.Max(left, right);
    }
}
