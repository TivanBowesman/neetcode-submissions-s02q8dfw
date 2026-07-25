public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        return nums.GroupBy(i => i)
        .OrderByDescending(i => i.Count())
        .Take(k) 
        .Select(i => i.Key)
         
        .ToArray();
    }
}
