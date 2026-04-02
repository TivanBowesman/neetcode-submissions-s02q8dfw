public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //return the k top k elements of hashmap
        //initialise hashmap
        var map = new Dictionary<int, int>();
        //adding elements to the map with frequencies
        foreach(int i in nums){
            if (map.ContainsKey(i)){
                map[i]++;
            }
            else{
                map[i] = 1;
            }
        }
        //sort map keys
        var Sorted = map.OrderByDescending(p => p.Value)
            .Select(p => p.Key)
            .Take(k)
            .ToArray();
        return Sorted;
    }
}
