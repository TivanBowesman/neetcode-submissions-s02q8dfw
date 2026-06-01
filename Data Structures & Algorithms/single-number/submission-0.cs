public class Solution {
    public int SingleNumber(int[] nums) {
        
       var single =  nums
        .GroupBy(num => num)
        .Select(num => new {number = num.Count(), key = num.Key} )
        .Where(num => num.number == 1 )
        .First();

        return single.key;
    }
}
