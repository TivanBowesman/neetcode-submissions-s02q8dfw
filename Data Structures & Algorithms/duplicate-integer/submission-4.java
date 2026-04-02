class Solution {
    public boolean hasDuplicate(int[] nums) {
        Set<Integer> hashset = new HashSet<>();

        for(int i : nums){
            hashset.add(i);
        }
        return hashset.size() != nums.length;
    }

    
}