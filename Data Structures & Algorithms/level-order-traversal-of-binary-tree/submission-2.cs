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
        //edge case
        if (root is null ) return new List<List<int>>( ); 
        var list = new List<List<int>>(); 
        var queue = new Queue<TreeNode>(); 
        
        //add root to the queue
        queue.Enqueue(root);

        while(queue.Any()){
            int len = queue.Count;
            var values = new List<int>();
            for (int i  = 0; i < len; i++){
                TreeNode node = queue.Dequeue();

                if(!(node is null)){
                    values.Add(node.val);

                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }

                
            }

            if (values.Any()){
                list.Add(values);
                //Console.WriteLine(new string(values.ToCharArray().ToCharArray()));
            }
        }

        return list;
    }
}
