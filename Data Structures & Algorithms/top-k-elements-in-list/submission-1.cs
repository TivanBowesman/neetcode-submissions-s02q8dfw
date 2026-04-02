public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // count frequencies in hash map
        // sort 
        // add sorted to hashset for unique numbers in order
        // return top k from sorted 

        var map = new Dictionary<int,int>();

        foreach (int i in nums){
            if (map.ContainsKey(i)){
                map[i] += 1;
            }else{
                map.Add(i,1);
            }
        }
        var sorted = map.OrderByDescending(x => x.Value)
                        .Select(x => x.Key)
                        .Take(k)
                        .ToArray();

        return sorted;

    }
}
