public class Solution {
    public int[] cost;
    public int MinCostClimbingStairs(int[] cost) {
        this.cost = cost;
        //edge case
        
        var len = cost.Length;
        if(len == 2){
            return Math.Min(cost[0], cost[1]);
        }
        var memo = new int[len + 1]; 
        Array.Fill(memo, -1 );
        //base cases
        memo[0] = 0;
        memo[1] = 0;

        return helper(memo, len);
    }
    //choose and not choose
    public int helper(int[] memo, int i){
        //check memo 
        if(memo[i] != -1){
            return memo[i];
        }
        // pick 1 + i  or 2 + i

        memo[i] = Math.Min(cost[i - 2] + helper(memo, i - 2), cost[i - 1 ] + helper(memo, i - 1));

        return memo[i];
    }
}
