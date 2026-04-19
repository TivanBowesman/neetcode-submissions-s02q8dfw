"""
Definition of Interval:
class Interval(object):
    def __init__(self, start, end):
        self.start = start
        self.end = end
"""

class Solution:
    def minMeetingRooms(self, intervals: List[Interval]) -> int:
        intervals.sort(key = lambda x: x.start)
        minHeap = []

        heapq.heapify(minHeap)

        for i in intervals:
            #bigger means after (later)
            if minHeap and i.start >= minHeap[0]:
                heapq.heappop(minHeap)
            
            #add to heap
            heapq.heappush(minHeap, i.end)

        return len(minHeap)