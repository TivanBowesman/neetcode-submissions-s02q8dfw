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
        //use queue 
        //Enqueue - Dequeue
        var list = new List<List<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        //while root is not null 
        while(queue.Any()){
            // get node 
            int q = queue.Count;
            var values = new List<int>();

            for (int i = 0; i < q ; i++){
                var node = queue.Dequeue();
                if (node != null){
                    values.Add(node.val);

                    //left then right 
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);

                }
            }

            if (values.Any()) {
                list.Add(values);
            }

        }

        return list;

    }
}
