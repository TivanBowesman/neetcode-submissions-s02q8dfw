class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        self.res = []
        self.target = target
        candidates.sort()  
        self.backtrack(candidates, 0, 0, [])
        return self.res

    def backtrack(self, nums, index, currSum, currArray):
        #base case
        if currSum == self.target:
            self.res.append(list(currArray))
            return 

        if index == len(nums):
            return
        
        
        for i in range(index , len(nums)):

            #skip dupes
            if i > index and nums[i] == nums[i - 1]:
                continue

            if currSum + nums[i] > self.target:
                continue

            currSum += nums[i]

            currArray.append(nums[i])

            self.backtrack(nums, i + 1, currSum, currArray)

            currArray.pop()
            currSum -= nums[i]

    
    # loop over it using for loop 