public class KthLargest {
    int _k;
    PriorityQueue<int,int> pq;
    public KthLargest(int k, int[] nums) {
        _k = k;
        pq = new PriorityQueue<int,int>();
        foreach(var num in nums){
            pq.Enqueue(num,num);
        }
        
    }
    
    public int Add(int val) {
        pq.Enqueue(val,val);

        while(pq.Count > _k){
            pq.Dequeue();
        }

        return pq.Peek();
    }
}
