public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        //return max non overlapping 
        
        //sort by end times 
        Array.Sort(intervals, (a,b) => a[1].CompareTo(b[1]));

        var overlap = 0;

        var prevEnd = intervals[0][1];

        for(int i = 1; i < intervals.Length; i++){
            var currStart = intervals[i][0];

            if (prevEnd > currStart){
                overlap ++;
            }else{
                prevEnd = intervals[i][1];
            }
        }

        return overlap;
    }
}
