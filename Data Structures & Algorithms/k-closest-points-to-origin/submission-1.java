class Solution {
    public int[][] kClosest(int[][] points, int k) {

        // Min-heap storing {distanceSquared, index}
        PriorityQueue<int[]> pq = new PriorityQueue<>(
            (a, b) -> Integer.compare(a[0], b[0])
        );

        // Store distance and point index
        for (int i = 0; i < points.length; i++) {
            int x = points[i][0];
            int y = points[i][1];
            int dist = (x*x) + (y*y) ;

            pq.add(new int[]{dist, i});
        }

        int[][] res = new int[k][2];

        // Extract k closest
        for (int i = 0; i < k; i++) {
            int idx = pq.poll()[1];
            res[i] = points[idx];
        }

        return res;
    }
}