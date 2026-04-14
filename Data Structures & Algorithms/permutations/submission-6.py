class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        self.res = []
        self.backtrack(nums,[])
        return self.res

    def backtrack(self,nums,currArray, ):
        if len(currArray) == len(nums):
            self.res.append(list(currArray))
            return

        # pick
        for i in nums:
            if i in currArray:
                continue

            currArray.append(i)
            self.backtrack(nums,currArray)
            currArray.pop()

