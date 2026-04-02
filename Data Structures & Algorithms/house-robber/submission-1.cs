public class Solution {
    public int[] nums;
    public int Rob(int[] nums) {
        var len = nums.Length;
        if(len == 1) return nums[0];
        if(len == 2) return Math.Max(nums[0], nums[1]);
        //must be three below
        this.nums = nums;

        //if i-1  > i -2 + i pick
        var memo = new int[len ];
        Array.Fill(memo, -1);
        //base case
        memo[0] = nums[0]; 
        memo[1] = Math.Max(nums[0], nums[1]);

        return helper(memo, len - 1);


    }

    //pick-dont-pick structure
    public int helper(int[] memo, int i){
        //check memo
        if(memo[i] != -1){
            return memo[i];
        }

        
        memo[i] = Math.Max(
            helper(memo, i - 1),
            nums[i] + helper(memo, i - 2)
        );

        return memo[i];
    }
}
