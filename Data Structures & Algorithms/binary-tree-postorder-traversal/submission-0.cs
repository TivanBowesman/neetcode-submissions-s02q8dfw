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
    public List<int> PostorderTraversal(TreeNode root) {
        var list = new List<int>( );

        postorder(root,list);

        return list;
    }

    public void postorder(TreeNode root, List<int> list){
        if(root is null) return;

        //;eft right node

        postorder(root.left,list);
        postorder(root.right,list);
        list.Add(root.val);
    }
}