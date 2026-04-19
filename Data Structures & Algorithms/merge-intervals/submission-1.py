class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        #sort by start times
        intervals.sort(key = lambda x: x[0])
        res = [intervals[0]]

        #if interval update end 
        
        #if not interval  create new start
        currIndex = 0
        prevend = intervals[0][1]
        for start,end in intervals:
            prevend = res[-1][1]

            # overlapping
            if start <= prevend:
                res[-1][1] = max(prevend,end)
            #non-overlapping
            else:
                res.append([start,end])

        return res

    

    #interval = prevEnd > nextStart