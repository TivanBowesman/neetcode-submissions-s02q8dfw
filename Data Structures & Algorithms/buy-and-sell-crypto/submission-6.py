class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        # return the max profit possible

        maxProfit = 0
        
        l = 0
        # if smaller is found move window along

        for r in range(len(prices)):
            currPrice = prices[r]
            
            if prices[l] > currPrice:
                #slide window along
                l = r
            
            maxProfit = max(maxProfit, currPrice - prices[l])

        return maxProfit