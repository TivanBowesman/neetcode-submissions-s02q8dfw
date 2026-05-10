public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        var minheap = new PriorityQueue<int, (int ,int)>(); 
        //value , priority(this, then this)
        var list = new List<int>();

        foreach(var num in arr){
            minheap.Enqueue(num, (Math.Abs(x - num),num)); 
         
        }

        for(int i = 0; i < k; i++){
            list.Add(minheap.Dequeue()); 
        }
        list.Sort();
        return list;
    }
}