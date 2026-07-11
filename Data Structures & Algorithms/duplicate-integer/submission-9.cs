public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashset = new HashSet<int>();

        foreach(var i in nums){
            if(!hashset.Add(i)) return true;
        }
        return false;
    }
}