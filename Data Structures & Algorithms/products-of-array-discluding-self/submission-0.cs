public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // hashmap store 
        //use LINQ if value is not the current index of loop return the product of the sums
        //
        var result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++){
            int bases = 1;
            for (int j = 0; j < nums.Length; j++){
                if( j != i){
                    bases *= nums[j];
                }
            }
            result[i] = bases;
        }

        return result;
    }
}   
