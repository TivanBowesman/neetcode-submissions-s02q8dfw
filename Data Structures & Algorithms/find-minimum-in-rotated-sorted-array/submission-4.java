class Solution {
    public int findMin(int[] nums) {
        //if the left is bigger than right
        //ther it is rotated
        //12345
        //51234

        int l = 0;
        int r = nums.length - 1; 

        while(l <= r){
            var mid = l + (r-l) / 2;

            if(nums[mid] < nums[r]){
                r = mid;
            }else{
                l = mid + 1;
            }
        }

        return nums[r];
    }
}
