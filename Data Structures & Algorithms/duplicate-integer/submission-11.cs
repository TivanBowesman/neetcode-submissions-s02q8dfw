public class Solution {
    public bool hasDuplicate(int[] nums) {
        var h = new HashSet<int>(nums);

        return !(nums.Length == h.Count);
    }
}