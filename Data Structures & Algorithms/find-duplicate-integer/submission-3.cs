public class Solution {
    public int FindDuplicate(int[] nums) {
        var hashset = new HashSet<int>(); 
        foreach(var num in nums){
            if (!hashset.Add(num)) return num;
        }

        return -1;
    }
}
