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
    public List<int> PreorderTraversal(TreeNode root) {
        var list = new List<int>(); 

        preorder(root, list);

        return list; 
    }
    public void preorder(TreeNode root, List<int> list){
        if (root is null ){
            return;
        }
        list.Add(root.val);
        preorder(root.left,list);
        
        preorder(root.right, list);
    }
}