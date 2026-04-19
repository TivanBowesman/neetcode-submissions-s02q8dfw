public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        //intervals is already sorted

        //interval = prevEnd > currStart 

        //add -> sort -> merge
        var list = new List<int[]>(intervals);
        list.Add(newInterval); 

        //sort 
        list.Sort((a,b) => a[0].CompareTo(b[0]) );

        //merge
        var start = list[0][0];
        var prevEnd = list[0][1];
        var res = new List<int[]>();

        for(int i = 1; i < list.Count(); i++){
            var currStart = list[i][0]; 
            var currEnd = list[i][1];
            //check for overlap
            if(prevEnd >= currStart){
                prevEnd = Math.Max(prevEnd,currEnd );
            }else{
                //no over lap here
                res.Add(new int[]{start, prevEnd});
                start = currStart;
                prevEnd = currEnd;
            }
        }

        //add final list
        res.Add(new int[] {start,prevEnd});
        return res.ToArray();
        
    }
}
