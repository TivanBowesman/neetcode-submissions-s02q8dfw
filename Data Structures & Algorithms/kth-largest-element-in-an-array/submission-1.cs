public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var minheap = new PriorityQueue<int,int>();

        foreach (int num in nums){
            //add to minheap 
            minheap.Enqueue(num,num);
            if(minheap.Count > k){
                minheap.Dequeue();
            }

            //45 k = 2
            //
        }
        return minheap.Count < 1 ? 0: minheap.Peek();

    }
}
