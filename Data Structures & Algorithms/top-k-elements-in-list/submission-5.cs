public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var arr = new List<int>(k);

        var map = new Dictionary<int,int>();
        var gb = nums.GroupBy(i => i)
        .Select(i => new 
            {
                num = i.Key, 
                count = i.Count()
            })
        .OrderByDescending(i => i.count)
        .Take(k)
        .Select(i => i.num)
        .ToArray();

        return gb;
    }
}
