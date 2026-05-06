public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // use max heap 
        // 2 23 231 21 215 21 214 
        // 2 - 23 231 23 235 35 354 34 
    
        var  maxheap = new PriorityQueue<int,int>(); 
       foreach (var i in nums){
        maxheap.Enqueue(i, i); 

        while(maxheap.Count > k){
            maxheap.Dequeue();
        }

       } 

       return maxheap.Peek( );
    }
}
