public class Solution {
    public int ClimbStairs(int n) {     
        //memo 

        var memo = new int[n + 1];

        if(n <= 2){
            return n; 
        }
        
        //n is bigger than 2
        memo[1] = 1;
        memo[2] = 2;

        return helper(n,memo);
    }

    public int helper(int n, int[] memo){
        //check memo
        if(memo[n] != 0){
            return memo[n];
            
        }

        //add to memo
        memo[n] = helper(n-1,memo) + helper(n-2,memo);
        return memo[n];
    }
}
