public class Solution {
    public int SingleNumber(int[] nums) {
        
       var single =  nums
        .GroupBy(num => num)
        .Where(num => num.Count() == 1 )
        .First();

        return single.Key;
    }
}
