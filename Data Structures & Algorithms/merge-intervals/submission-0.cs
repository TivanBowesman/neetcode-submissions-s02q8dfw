public class Solution {
    public int[][] Merge(int[][] intervals) {
        var len = intervals.Length; 
        if (len == 1){
            return new int[][]{new int[]{intervals[0][0], intervals[0][1]}};
        }
        
        var list = new List<int[]>();

        //sort in place
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        var start = intervals[0][0];
        var prevEnd = intervals[0][1];

        for (int i = 1; i < len; i++){
            var currEnd = intervals[i][1];
            var currStart = intervals[i][0];

            //find non overlapping area
            if (currStart <= prevEnd) {
                // overlapping:  extend prevEnd
                prevEnd = Math.Max(prevEnd, currEnd);
            } else {
                // non-overlapping: save current interval, move to next
                list.Add(new int[] { start, prevEnd });
                start = currStart;
                prevEnd = currEnd;
            }

            
        }
        list.Add(new int[]{start, prevEnd});
        //interval = prevend > newstart

        //go until you dont find an interval
        //list.Add(new List<int>{start, newEnd});

        return list.ToArray();
    }

    // combine intervals
    // new end = max(prevend, curr end)
}
