class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        self.target = target
        self.res = []
        self.backtrack(nums,0,0,[])
        return self.res
    
    def backtrack(self, nums, currIndex, currSum, currArray):
        #base case
        if currSum == self.target:
            self.res.append(currArray.copy())
            return

        if currIndex >= len(nums) or currSum > self.target:
            return
         
        
        
        # dont pick 
        self.backtrack(nums, currIndex + 1, currSum, currArray)

        # pick
        currSum += nums[currIndex]
        currArray.append(nums[currIndex])
        self.backtrack(nums, currIndex, currSum, currArray)
        currArray.pop()
    
    #unique elements in the array
