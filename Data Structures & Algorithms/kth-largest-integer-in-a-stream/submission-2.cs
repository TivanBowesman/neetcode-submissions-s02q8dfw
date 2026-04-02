public class KthLargest {
    private PriorityQueue<int,int> minheap;
    private int kth; 
    public KthLargest(int k, int[] nums) {
        kth = k;
        //min heap
        minheap = new PriorityQueue<int,int>();

        foreach(int num in nums){
            Add(num);
        }

    }
    
    public int Add(int val) {
        minheap.Enqueue(val,val);

        while(minheap.Count > kth){
            minheap.Dequeue();
        }
        return minheap.Peek();
    }
}
