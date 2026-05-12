public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1; 

        while (l <= r){
            int mid = l + (r - l)/2;
            //1, 2,3 ,4 ,5
            int sum = nums[mid];

            if (sum == target){
                return mid;
            }else if (sum < target){
                l++;
            }else{
                r--;
            }

        }

        return l;
    }
}