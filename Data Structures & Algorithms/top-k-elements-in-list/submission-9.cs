public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.GroupBy(i => i)
        .OrderByDescending(i => i.Count())
        .Select(i => i.Key)
        .Take(k)  
        .ToArray();
    }
}
