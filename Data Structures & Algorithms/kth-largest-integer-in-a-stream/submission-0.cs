public class KthLargest {
    private PriorityQueue<int,int> minHeap;
    private int kth;
    public KthLargest(int k, int[] nums) {
        //inside constructor method
        kth = k;
        minHeap = new PriorityQueue<int,int>();

        foreach(int num in nums){
            Add(num);
        }


    }
    
    public int Add(int val) {
        //add to the heap
        minHeap.Enqueue(val,val);
        //remove items over the k
        while(minHeap.Count > kth){
            minHeap.Dequeue();
        }

        return minHeap.Peek();


    }
}
