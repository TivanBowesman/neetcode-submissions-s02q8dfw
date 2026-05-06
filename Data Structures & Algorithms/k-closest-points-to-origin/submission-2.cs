public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        //Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        //ad points to min heap 
        // return the top ogf the heap 
        var minheap = new PriorityQueue<int[],double>();
        //(points[i], euclidean distance)
        foreach (var point in points){
            var dist = Math.Sqrt(Math.Pow(point[0] - 0, 2) + Math.Pow(point[1] - 0, 2));
            Console.WriteLine(dist);
            minheap.Enqueue(point, dist);
        }

        var list = new List<int[]>();
        for(int i = 0; i < k; i++){
            list.Add(minheap.Dequeue());
        }

        return list.ToArray();
    }
}
