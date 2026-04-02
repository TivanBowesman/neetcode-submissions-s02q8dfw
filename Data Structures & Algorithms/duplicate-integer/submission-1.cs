public class Solution {
    public bool hasDuplicate(int[] nums) {
        var sets = new HashSet<int>();
        foreach(int i in nums){
            sets.Add(i);
        }

        if (sets.Count == nums.Length){
            return false;
        }
        return true;
    }
}

