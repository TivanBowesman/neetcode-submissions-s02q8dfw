public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var memo = new int[cost.Length + 1];
        Array.Fill(memo, -1);
        memo[0] = 0;
        memo[1] = 0;
        
        return helper( memo,cost, memo.Length -1);
    }

    public int helper(int[] memo, int[] cost, int i){
        //check memo
        if(memo[i] != -1){
            return memo[i];
        }

        memo[i] = Math.Min(cost[i-2] + helper(memo,cost,i - 2),cost[i-1] + helper(memo,cost, i - 1));

        return memo[i];
    }
}
