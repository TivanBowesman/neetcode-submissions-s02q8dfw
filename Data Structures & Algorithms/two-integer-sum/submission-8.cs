public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>(); 
        
        for (int i = 0; i < nums.Length; i++) {
            
            int complement = target - nums[i]; // Find the number needed
            
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i }; // Return indexes
            }
            
            map.Add(nums[i],i);// Store the current number and its index
        }
        
        return new int[] {}; // No solution found 
    }
}
