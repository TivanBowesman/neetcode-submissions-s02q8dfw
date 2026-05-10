public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int size = int.MaxValue;
        int l = 0; 
        int sum = 0; 

        for(int r = 0; r < nums.Length; r++){
            sum += nums[r];
            
            while (sum >= target) {
            size = Math.Min(size, (r - l) + 1);
            sum -= nums[l];
            l++;
        }
            
        }

        return size == int.MaxValue ?  0 : size ;
    }
}