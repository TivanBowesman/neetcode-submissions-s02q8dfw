class Solution {
    public int count;
    public int climbStairs(int n) {
        //use rescursive tree
        // find the memo approach
        count = 0;
        var memo = new int[n+1];
        
        if(n <= 2){
            return n;
        }

        memo[1] = 1; 
        memo[2] = 2;

        return helper( n, memo);
    }

    public int helper( int n, int[] memo){
        //check memo
 
        if (memo[n] != 0){
            return memo[n];
        }
        
        //add to memo
        memo[n] = helper( n-2, memo) + helper( n-1, memo);

        return memo[n];
    }
}
