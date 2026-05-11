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
    public List<int> InorderTraversal(TreeNode root) {
        //left node right
        var list = new List<int>();
        inorder(root, list);

        return list;
    }

    public void inorder(TreeNode root, List<int> list){
        if (root is null ){
            return;
        }

        inorder(root.left,list);
        list.Add(root.val);
        inorder(root.right, list);
    }


}