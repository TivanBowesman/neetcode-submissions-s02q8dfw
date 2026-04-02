public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        
        while ( l < r){
            int m = l + (r-l)/2;
            
            if (nums[m] > nums[r]){
                l = m + 1; 
            }else{
                r = m;
            }
            
        }
        int min_index = l;
        if (target >= nums[min_index] && target <= nums[nums.Length-1]){
            l = min_index;
            r = nums.Length - 1;
        }else{
            l = 0;
            r = min_index-1;
        }

        while (l <= r){
            int m = l + (r-l)/2;

            if (nums[m] == target){
                return m;
            }else if (nums[m] > target){
                r = m - 1;
            }else{
                l = m + 1;
            }
        }
        return -1;
    }
}
/*
    find min index 
    compare with rest of list 
    run binary search after comparing
*/
