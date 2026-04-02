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
    public List<int> RightSideView(TreeNode root) {
        //edge case
        if (root is null ) return new List<int>();

        var list = new List<int>();
        var q = new Queue<TreeNode>();

        q.Enqueue(root);

        while (q.Any()){
            TreeNode right = null;
            int len = q.Count;
            //queues remove from the front
            for (int i = 0; i < len; i++){
                var node = q.Dequeue();
                if (node != null){
                    right = node;

                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            
            if (right != null)list.Add(right.val);
            
        }
        return list;

    }
}
