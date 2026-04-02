public class Solution {
    public int ClimbStairs(int n) {     
        if (n == 1 || n == 2) return n; 
        //a = 1 b = 2 c = a+b
        var memo = new int[n+1];

        memo[1] = 1;
        memo[2] = 2;

        return helper(memo, n);
    }

    public int helper(int[] memo, int i){
        if(memo[i] != 0){
            return memo[i];
        }
        memo[i] = helper(memo, i - 1) + helper(memo, i - 2);

        return memo[i];
    }
}
