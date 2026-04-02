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
    public List<List<int>> LevelOrder(TreeNode root) {
        //use of a queue
        if (root is null ) return new List<List<int>>(); 

        var queue = new Queue<TreeNode>();
        var list = new List<List<int>>();
        
        queue.Enqueue(root);
        while(queue.Any()){
            var sub = new List<int>();
            var len = queue.Count; 

            for(int i = 0; i < len; i++){
                var item = queue.Dequeue();

                sub.Add(item.val);

                if (item.left != null){
                    queue.Enqueue(item.left);
                }
                if (item.right != null){
                    queue.Enqueue(item.right); 
                }
            }

            list.Add(sub);
        }

        return list; 
    }
}
