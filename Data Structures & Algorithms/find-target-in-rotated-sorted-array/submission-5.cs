public class Solution {
    public int Search(int[] nums, int target) {
        // find min
        int l = 0;
        int r = nums.Length-1;

        while(l < r){
            int mid = l + (r-l)/2;

            if (nums[mid] > nums[r]){
                l = mid+1;
            }else{
                r = mid;
            }

        }
        int min_index = l;
        // check if the target is within range
        if(target >= nums[min_index] && target <= nums[nums.Length - 1]){
            l = min_index;
            r = nums.Length - 1;
        }else{
            l = 0;
            r = min_index - 1;
        }

        while (l <= r){
            int mid = l+(r-l) /2;

            if (nums[mid] == target){
                return mid;
            }else if (nums[mid] > target){
                r = mid-1;
            }else{
                l = mid +1;
            }
        }
        return - 1;
    }
}
