public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        var list = new List<List<int>>();

        for (int i = 0; i < nums.Length - 2; i++){
            //edge cases
            if (nums[i] > 0) break; //beacuse its impossible to equal 0 at this point

            //move pointer along as we've already checked for all combos with that value
            if (i > 0 && nums[i] == nums[i-1]) continue;

            //two pointer approach 
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right){
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0){
                    //add to list to list 
                    list.Add(new List<int>(){nums[i],nums[left],nums[right]});
                    left++;
                    right--;
                    //elim dupe chances
                    while(left < right && nums[left] == nums[left - 1]){
                        //move left as right could be out of bounds
                        left++;
                    }
                }else if (sum > 0){
                    right--;
                }else{
                    left++;
                }
            }
        }
        return list;
    }
}
