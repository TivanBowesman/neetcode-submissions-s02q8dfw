"""
Definition of Interval:
class Interval(object):
    def __init__(self, start, end):
        self.start = start
        self.end = end
"""

class Solution:
    def canAttendMeetings(self, intervals: List[Interval]) -> bool:
        # interval = prevEnd > nextStart
        if len(intervals) == 0:
            return True

        #sort by start times
        intervals.sort(key=lambda x: x.start)
        
        prevEnd = intervals[0].end
        for i in range(1, len(intervals)):
            currStart = intervals[i].start

            if prevEnd > currStart:
                return False
            
            prevEnd = intervals[i].end
        

        return True
    

    # sort by start time:
        # check if prev end is bigger than next start 

