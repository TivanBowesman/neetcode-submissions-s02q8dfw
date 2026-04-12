class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        self.res = []

        self.backtrack(nums, 0, [])

        return self.res
    
    def backtrack(self, nums, currIndex,  currArray):
        #base case 
        if currIndex == len(nums):
            self.res.append(list(currArray))
            return
        #dont pick 
        self.backtrack(nums, currIndex + 1, currArray)

        #pick
        currArray.append(nums[currIndex])
        self.backtrack(nums,currIndex + 1, currArray)
        currArray.pop()
