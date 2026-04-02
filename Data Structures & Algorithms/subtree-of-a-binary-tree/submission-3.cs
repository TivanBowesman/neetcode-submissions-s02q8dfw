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
        //compare from each node 
        //so if its ever true
        if (root is null ) return false;

        if(same(root,subRoot)) return true;
        //compare the same for subroot but look recursively throught the left and right of root
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);


    }

    public static bool same (TreeNode node, TreeNode Cnode){
        if (node is null && Cnode is null) return true; 

        if(node is null || Cnode is null ) return false;

        if (node.val != Cnode.val) return false;

        return same(node.left, Cnode.left) && same(node.right,Cnode.right);
    }
}
