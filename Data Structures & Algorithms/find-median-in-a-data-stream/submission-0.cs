public class MedianFinder {
    public List<int> arr;
    public MedianFinder() {
        arr = new List<int>();
    }
    
    public void AddNum(int num) {
        arr.Add(num);
    }
    
    public double FindMedian() {
        var pq = new PriorityQueue<int, int>(); 
        var isEven = arr.Count % 2 == 0; 
        
        //populate pq
        foreach(var num in arr){
            pq.Enqueue(num,num);
        }

        if (pq.Count == 1){
            return pq.Peek();
        }

        while(pq.Count > (arr.Count / 2) + 1){
            pq.Dequeue();
        }
        
        return isEven ? (pq.Dequeue() + pq.Dequeue()) / 2.0 : pq.Peek() ;
        
        
    }
}

//use pq