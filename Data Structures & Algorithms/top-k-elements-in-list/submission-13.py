class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        map = {}

        for i in nums:
            if i in map.keys():
                map[i] += 1
            else:
                map[i] = 1

        heap = []
        for key in map.keys():
            heapq.heappush(heap, (map[key],key))

            if len(heap) > k:
                heapq.heappop(heap)
            
        res = []

        for r in range(k):
            print(r)
            res.append(heapq.heappop(heap)[1])

        return res