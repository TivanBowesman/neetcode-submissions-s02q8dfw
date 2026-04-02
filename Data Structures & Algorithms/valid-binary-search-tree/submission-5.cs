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
    public bool IsValidBST(TreeNode root) {
        return dfs(root, Int32.MinValue, Int32.MaxValue);
    }

    //helper function

    public bool dfs(TreeNode node,int minNodeVal,int  maxNodeVal){
        //base case
        if (node is null) return true;
        //check to see if it fits in the ideal range to be valid 
        if(!(node.val < maxNodeVal && node.val > minNodeVal)){
            return false;
        }

        return dfs(node.left,minNodeVal, node.val  ) && dfs(node.right, node.val, maxNodeVal);
    }
}
