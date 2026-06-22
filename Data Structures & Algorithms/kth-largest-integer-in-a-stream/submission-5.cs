public class KthLargest {
    private PriorityQueue<int,int> pq;
    int _k;
    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int,int>();
        for(int i = 0; i < nums.Length; i++){
            pq.Enqueue(nums[i], nums[i]);
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
