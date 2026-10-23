class Solution {
    public boolean hasDuplicate(int[] nums) {
        HashSet<Integer> hashset = new HashSet<Integer>();
        for(int i : nums){
            hashset.add(i);
        }

        return hashset.size() != nums.length;
    }
}