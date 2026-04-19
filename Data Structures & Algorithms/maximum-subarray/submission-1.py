class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        maximum = float('-inf')
        cSum = 0
        for i in nums:
            
            if cSum < 0:
                cSum = 0
            
            cSum += i
            maximum = max(maximum,cSum)
            
        return maximum