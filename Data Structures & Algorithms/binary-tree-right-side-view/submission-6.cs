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
        var list = new List<int>();

        //add to queue
        //bfs (left -> right)
        //last remaining item should be right side
        //dont just take right
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Any()){
            TreeNode right = null;
            var len = queue.Count;

            for(int i = 0; i < len; i++){
                var node = queue.Dequeue();

                //add left then right
                //handle null
                if(node != null){
                    right = node;
                    queue.Enqueue(right.left);
                    queue.Enqueue(right.right);
                }
                
            }

            if(right != null) list.Add(right.val);
        }

        return list;
    }
}
