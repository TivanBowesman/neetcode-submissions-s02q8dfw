class Solution:
    def eraseOverlapIntervals(self, intervals: List[List[int]]) -> int:
        #sort by the end times
        intervals.sort(key = lambda x: x[1])

        moves = 0

        #interval = prevend > currStart
        prevend = intervals[0][1]
        for i in range(1, len(intervals)):
            start = intervals[i][0]
            if prevend > start:
                moves += 1
                print(moves)
            else:
                prevend = intervals[i][1]

        if moves == 0:
            return 0

        return abs(moves )
