class Solution {
    public int[] productExceptSelf(int[] nums) {
        int len = nums.length;

        int[] left = new int[len];
        int[] right = new int[len];

        //get the left sum
        int sum = 1;
        for(int i = 0; i < len; i++){
            left[i] = sum;
            sum *= nums[i];
            System.out.println(sum);
            
        }
        
        System.out.println("safsas");
        //get right
        sum = 1;
        for(int i = len - 1; i >= 0; i--){
            right[i] = sum; 
            sum *= nums[i];
        }

        for(int i = 0; i < len; i++){
            nums[i] = left[i] * right[i];
        }

        return nums;
    }
}  
