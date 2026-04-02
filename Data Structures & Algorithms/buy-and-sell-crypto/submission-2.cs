public class Solution {
    public int MaxProfit(int[] prices) {
        /*
            array of price [10,2,7,8,7]

        */
        int profit = 0;
        int l = 0;

        for (int r = 1; r < prices.Length; r++){
            //start l at the beginning and r at 0;
            if (prices[l] < prices[r]){
                //profit to be made here
                int CurrentProfit = prices[r] - prices[l];
                profit = Math.Max(profit, CurrentProfit);
            }else{
                l=r;
            }
        }
        return profit;
    }
}
