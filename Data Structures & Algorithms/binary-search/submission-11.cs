public class Solution {
    public int Search(int[] nums, int target) {
        

        var ans = Array.BinarySearch(nums,target);
        return ans >= 0 ? ans : -1;
    }
}
