public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int sum = 0;
        foreach(var num in nums){
            sum += num;
            max = Math.Max(max, sum);
            if(sum < 0) {
                sum = 0;
            }
            
        }

        return max;
    }
}
