public class Solution {
    public int SingleNumber(int[] nums) {
        
       var single =  nums
        .GroupBy(num => num)
        .First(num => num.Count() == 1 );
        

        return single.Key;
    }
}
