public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        //use point as number
        var minheap = new PriorityQueue<int[], double>();

        foreach(var point in points){
            minheap.Enqueue(point,Euclidean(point));
        }

        var arr = new int[k][];
        for(int i = 0; i < k; i++){
            arr[i] = minheap.Dequeue();
        }

        return arr;

    }
    //use this as priotity 
    public double Euclidean(int[] point){
        //0 = x1, 0 = y1 
        //no need to subtract since its from 0
        int sum1 = point[0] * point[0];
        int sum2 = point[1] * point[1];

        return Math.Sqrt(sum1 + sum2);
    }
}
