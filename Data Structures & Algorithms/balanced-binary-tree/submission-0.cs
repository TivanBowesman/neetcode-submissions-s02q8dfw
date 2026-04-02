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

    public bool ans;
    public bool IsBalanced(TreeNode root) {

        ans = true;
        counter(root);
        return ans;


    }
    //function to count the left and right height
    private int counter(TreeNode root){
        //base case
        if (root == null) return 0;

        int left = counter(root.left);
        int right = counter(root.right);
        
        //check if tree is ever unbalanced
        if (Math.Abs(right - left ) > 1){
            ans = false;
        }

        return 1 + Math.Max(left,right);

    }
}
