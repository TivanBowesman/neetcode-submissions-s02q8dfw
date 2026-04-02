class Solution {
    public int[] twoSum(int[] nums, int target) {
        //to have some thing you can 
        //look up quickly to see of you have target - curr index

        Map<Integer, Integer> map = new HashMap<>();
        //num, index

        for(int i = 0; i < nums.length; i++){
            if(map.containsKey(target - nums[i])){
                return new int[]{map.get(target - nums[i]), i };
            }
            //add the num and index
            map.put(nums[i], i);
        }

        return new int[]{};
    }
}
