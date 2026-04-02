public class Solution {
    public bool hasDuplicate(int[] nums) {
        // pass into hashset 
        //if not add return false

        HashSet<int> dup = new();

        foreach(int i in nums ){
            if (!dup.Add(i)){
                return true;
            }
        }
        return false;
    }
}
