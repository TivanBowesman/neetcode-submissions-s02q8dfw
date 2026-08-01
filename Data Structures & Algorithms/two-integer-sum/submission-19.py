class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        map = {}
        
        index = 0

        for num in nums:
            check = target - num
            if check in map:
                return [map.get(check), index]

            map[num] = index
            index += 1


        return list();