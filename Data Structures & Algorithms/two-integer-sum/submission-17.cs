public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>(); // num , index

        for(int i = 0; i < nums.Length; i++){
            int lookup = target - nums[i];

            if(map.ContainsKey(lookup)) return new int[]{map[lookup], i};

            map[nums[i]] = i;
        }
        return new int[]{};
    }
}
