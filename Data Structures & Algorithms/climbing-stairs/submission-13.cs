public class Solution {
    public int ClimbStairs(int n) {     
        //1, 11 2, 21 12 111, 1111 112 211 22 121
        if(n <= 2) return n;
        
        var memo = new int[n + 1];
        Array.Fill(memo,-1);
        memo[0] = 0;
        memo[1] = 1;
        memo[2] = 2;
        
        helper(memo,n);

        return memo[n];
    }

    public int helper(int[] memo, int index){
        //check memo
        if(memo[index] != -1){
            return memo[index];
        }
        
        memo[index] = helper(memo, index -1) + helper(memo, index - 2);
        return memo[index];
    }
}
