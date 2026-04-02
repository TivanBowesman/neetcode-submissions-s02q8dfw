public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        var list = new List<List<int>>();
        Array.Sort(nums);
        Backtrack(0, nums, list, new List<int>());
        return list;
    }

    private void Backtrack(int i, int[] nums, List<List<int>> list, List<int> sub) {
        list.Add(new List<int>(sub));

        
        for (int start = i; start < nums.Length; start++) {
            //next loop
            if (i < start && nums[start] == nums[start-1]) continue;//skip dupes

            sub.Add(nums[start]);
            Backtrack(start + 1, nums, list, sub);
            sub.RemoveAt(sub.Count - 1);
        }
    }
}

