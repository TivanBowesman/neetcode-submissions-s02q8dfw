public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>(); 

        for(int i = 0; i < nums.Length; i++){
            var check = target - nums[i];
            if (map.ContainsKey(check)) return new int[]{map[check], i}; 

            map[nums[i]] = i;
        }

        return new int[]{};
    }
}
