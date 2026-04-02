class Solution {
    public int maxProfit(int[] prices) {
        int max = Integer.MIN_VALUE;

        int l = 0;
        for(int r = 0; r < prices.length; r++){
            int profit = prices[r] - prices[l];

            while(l < r && prices[l] > prices[r]){
                l++;
            }

            max = Math.max(max, profit);
        }

        return max;

    }
}
