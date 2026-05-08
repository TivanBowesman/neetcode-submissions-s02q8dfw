public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //build up values to the left and to the right
        // 1[1,1,2,8]1
        // 1[48,24,6,1]1
        
        //bulid up left arr 
        var left = new int[nums.Length]; 
        var sum = 1; 
        for(int i = 0; i < nums.Length; i++){
            left[i] = sum; 
            sum *= nums[i];
        }

        //build up right 
        sum = 1; 
        var right = new int[nums.Length];
        for(int i = nums.Length - 1; i >= 0; i--){
            right[i] = sum;
            sum *= nums[i];
        }

        for(int i = 0; i < nums.Length; i++){
            right[i] = right[i] * left[i];
        }

        return right;


    }
}
