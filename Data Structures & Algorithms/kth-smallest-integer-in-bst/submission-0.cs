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
    public List<int> list;
    public int KthSmallest(TreeNode root, int k) {
        // perform binary search?
        //if node to big look for smaller( left)
        // if node too  small lookr for bigger ( right)

        // in order traversal provides an in order list of a bst
        list = new List<int>();
        PostOrder(root,k, list);
        var arr = list.ToArray();
        
        return arr[k - 1];



    }

    public void PostOrder(TreeNode node, int k,List<int> list){
        //base case
        if (node is null) return;

        PostOrder(node.left, k, list);
        list.Add(node.val);
        PostOrder(node.right,k, list);

    }
}
