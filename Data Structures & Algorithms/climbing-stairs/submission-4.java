class Solution {
    public int count;
    public int climbStairs(int n) {
        //use rescursive tree
        // find the memo approach
        count = 0;
        
        helper(0,n);

        return count;
    }

    public void helper(int curr, int n){
        //break
        if(curr == n){
            count++;
            
            return;
        }

        if (curr > n ) return;

        //pick 1
        
        helper(curr + 1, n);
        //dont pick 1 (2)
        helper(curr + 2, n);

    }
}
