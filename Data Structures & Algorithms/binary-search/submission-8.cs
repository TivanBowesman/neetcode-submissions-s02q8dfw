public class Solution {
    public int Search(int[] nums, int target) {
        /*
            l + r / 2 = mid point 

        */

        int l = 0;
        int r = nums.Length-1;

        while(l <= r){
            int mid = l + ((r-l)/2);

            if (nums[mid] == target){
                return mid;
            }else if (nums[mid] > target){
                r = mid - 1;
            }else{
                l = mid + 1;
            }
        }
        return -1;
    }
}
