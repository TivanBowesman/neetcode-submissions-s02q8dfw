public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //add numbers to map
        // find the number by subtracting the index in the current loop from the index

        var map = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++){
            var numb = target - nums[i];
            if (map.ContainsKey(numb)){
                return new int[] {map[numb],i};
            }
            //add number and its index to the map 
            map.Add(nums[i],i);
        }
        return null;
    }
}
