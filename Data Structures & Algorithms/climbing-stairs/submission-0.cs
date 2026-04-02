public class Solution {
    public int ans = 0;
    public int ClimbStairs(int n) {     
        
        dfs(n, 0);
        return ans;
    }
    public void dfs(int n,int curr){
        //base case
        if(curr == n){
            ans++;
            return;
        }
        if(curr > n){
            return;
        }
    
        //pick 1
        dfs(n,curr+1);
        
        // dont pick 1(2)
        dfs(n, curr+2);
        
    }
}
