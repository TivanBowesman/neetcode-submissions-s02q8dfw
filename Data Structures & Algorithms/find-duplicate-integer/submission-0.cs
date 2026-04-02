public class Solution {
    public int FindDuplicate(int[] nums) {
        var hashset = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++){
            if (!hashset.Add(nums[i])){
                return nums[i];
            }
        }
        return 0;
    }
}
