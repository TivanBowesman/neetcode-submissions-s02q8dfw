public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int maxProfit = 0;

        for(int r = 1; r < prices.Length; r++){
            int current = prices[r] - prices[l];
            if (prices[l] < prices[r]){
                maxProfit = Math.Max(maxProfit,current);
            }else{
                l = r;
            }
            
        }

        return maxProfit;
    }
}
