public class Solution {
    public int Search(int[] nums, int target) {
        var list = new List<int>(nums);

        var ans = list.BinarySearch(target);
        return ans >= 0 ? ans : -1;
    }
}
