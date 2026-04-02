class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        #check if a num in a map matches the remainang total 

        # store first num
        map = {}
        map[nums[0]] = 0

        for i in range(1,len(nums)):
            remain = target - nums[i]

            if remain in map:
                return [map[remain], i]

            map[nums[i]] = i
                
        