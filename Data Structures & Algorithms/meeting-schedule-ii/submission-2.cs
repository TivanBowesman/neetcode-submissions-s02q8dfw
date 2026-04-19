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
    public int MinMeetingRooms(List<Interval> intervals) {
        //sort by start time
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        //use min heap
        var pq = new PriorityQueue<int,int>(); 

        foreach (var interval in intervals){
            //if the start time is after the end you can use the room again
            if(pq.Count > 0  && interval.start >= pq.Peek()){
                pq.Dequeue();
            }
            //add to heap 
            pq.Enqueue(interval.end,interval.end);
            
        }

        return pq.Count;
    }
}
