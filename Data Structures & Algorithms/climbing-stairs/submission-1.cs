public class Solution {
    public int ClimbStairs(int n) {     
        
        return dfs(n, 0);

    }
    public int dfs(int n,int curr){
        //base case 
        if(n < curr ) return 0; 
        if(n == curr) return 1;

        return dfs(n,curr+1) + dfs(n, curr + 2);
        
    }
}
