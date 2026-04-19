/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        var len = intervals.Count();
        if (len  == 0){
            return true;
        }
        //sort by start times 
        intervals.Sort((a,b) => a.start.CompareTo(b.start) );

        int prevEnd = intervals[0].end;

        for (int i = 1; i < len; i++) {
            int currStart = intervals[i].start;

            if (prevEnd > currStart) {
                return false;
            }

            // update prev end
            prevEnd = intervals[i].end;
        }
        return true;
    }
}
