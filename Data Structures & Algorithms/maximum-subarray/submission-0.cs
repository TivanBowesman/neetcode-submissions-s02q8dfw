public class Solution {
    public int MaxSubArray(int[] nums) {
        //if below zero reset to zero 
        int max = int.MinValue;
        int current = 0; 
        foreach(int num in nums){
            if (current < 0){
                current = 0; 
            }
            current += num;
            max = Math.Max(current,max);

        }

        return max; 
    }
}
