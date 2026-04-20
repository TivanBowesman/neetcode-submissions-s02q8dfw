public class Solution {
    public int ClimbStairs(int n) {  
        if (n == 1){
            return 1;
        }
        var memo = new int[n+1];
        Array.Fill(memo, -1);
        //populate the memo
        memo[1] = 1;
        memo[2] = 2;
        helper(n,memo);
        return memo[n];
    }

    public int helper(int i, int[] memo ){
        //check memo
        if(memo[i] != -1 ){
            return memo[i];
        }

        memo[i] = helper(i - 2, memo) + helper(i - 1,memo);

        return memo[i];
    }

    //1,2,3
}
