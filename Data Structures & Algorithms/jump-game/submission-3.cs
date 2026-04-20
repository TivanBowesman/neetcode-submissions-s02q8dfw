public class Solution {
    public bool CanJump(int[] nums) {
        //reach(next pos) = i + nums[i]
        var currPos = 0;

        for (int i = 0; i < nums.Length; i++){
            if (i > currPos) return false;
            //update the curr pos
            currPos = Math.Max(currPos, i + nums[i]);
        }

        return true;
    }
}
