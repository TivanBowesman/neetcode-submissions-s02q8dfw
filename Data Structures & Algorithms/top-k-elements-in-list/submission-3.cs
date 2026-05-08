public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //max heap 
        //hashset
        //add until you have count of k 
        var maxheap = new PriorityQueue<int,int>(); 
        var map = new Dictionary<int, int>();

        foreach (var num in nums){
            if(map.ContainsKey( num)){
                map[num]++; 
            }else{
                map[num] = 1;
            }
        }

        foreach (var i in map.Keys){
            maxheap.Enqueue(i, -map[i]);
        }

        var list = new List<int>();

        while(list.Count != k){
            list.Add(maxheap.Dequeue());
        }

        return list.ToArray( );
    }
}
