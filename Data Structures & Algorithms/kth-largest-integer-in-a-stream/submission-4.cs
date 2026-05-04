public class KthLargest {
    PriorityQueue<int,int> minheap; 
    int k ;

    public KthLargest(int k, int[] nums) {

        minheap = new PriorityQueue<int,int>();
        foreach(var num in nums){
            minheap.Enqueue(num,num);
        
        }
        this.k = k;
    }
    
    public int Add(int val) {
        minheap.Enqueue(val,val);
        while(minheap.Count > k){
            minheap.Dequeue();
        }
        return minheap.Peek();
    }
}
