public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int,int>();// value, index 

        for (int i = 0; i < nums.Length; i++){
            //target = map[i] + x
            //map[i] = target - x
            int res = target - nums[i];
            if (map.ContainsKey(res)){
                return new int[]{map[res], i};
            }

            map[nums[i]] = i;
        }
        //🐐
        return null;
    }
}
