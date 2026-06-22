public class KthLargest {
    private PriorityQueue<int,int> pq;
    int _k;
    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int,int>();
        foreach(var num in nums){
            pq.Enqueue(num, num);
        }
        _k = k;
    }
    
    public int Add(int val) {

        pq.Enqueue(val,val);

        while(pq.Count > _k){
            pq.Dequeue();
        }
        
        return pq.Peek();
    }
}
