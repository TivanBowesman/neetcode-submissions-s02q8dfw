class Solution {
    public int search(int[] nums, int target) {
        //find the min 
        //look through both sides 

        //min index
        int l = 0;
        int r = nums.length - 1;

        while(l < r){
            int mid = l + (r - l ) / 2;

            if(nums[mid] < nums[r]){
                r = mid;
            }else{
                l = mid + 1;
            }
        }

        int min = l;

        if(nums[l] == target) return l;
        //decide where well look
        if(target >= nums[min] && target <= nums[nums.length - 1]){
            l = min; 
            r = nums.length - 1;
        }else{
            l = 0;
            r = min - 1;
        }

        while(l <= r){
            int mid = l + (r - l )/2;

            if (nums[mid] == target) return mid;
            
            if(nums[mid] > target){
                r = mid - 1;
            }else{
                l = mid + 1;
            }
        }

        return -1;

    }
}
