public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var arr = new List<int>(k);

        var map = new Dictionary<int,int>();
        var gb = nums.GroupBy(i => i)
        .OrderByDescending(i => i.Count())
        .Select(i => i.Key)
        .Take(k)  
        .ToArray();

        return gb;
    }
}
