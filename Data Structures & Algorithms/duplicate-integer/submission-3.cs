public class Solution {
    public bool hasDuplicate(int[] nums) {
        // create a hashset 
        //O(N) time
        var HashSet = new HashSet<int>(nums);
 
        return !(HashSet.Count == nums.Length);
    }
}