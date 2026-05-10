public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        //brute force 
        for(int i = 0; i < nums.Length - 1 ; i++){
            for(int j = i + 1; j < nums.Length; j++){
                var diff = Math.Abs(i -j) <= k;
                var same = nums[i] == nums[j];
                if(diff && same){
                    return true;
                }
            }
        }

        return false;
    }
}