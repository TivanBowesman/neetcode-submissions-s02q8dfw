public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ans = new int[2 * n]; 

        //0 + n - 1  =
        for(int i = 0; i < n; i++ ){
            ans[i] = nums[i];
            ans[i + n ] = nums[i];
        } 

        return ans; 
    }
}