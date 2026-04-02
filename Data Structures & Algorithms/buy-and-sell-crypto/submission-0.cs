public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int profit = 0;
        int l = 0;
        int r = 1;

        /*
            unsorted array
            return the max profit possible

        */

        while (l < r && r < prices.Length){
            if (prices[r] > prices[l]){
                profit = prices[r]-prices[l];
                max = Math.Max(max,profit);
            }else{
                l = r;
            }
            r++;
        }
        return max;
    }
}
