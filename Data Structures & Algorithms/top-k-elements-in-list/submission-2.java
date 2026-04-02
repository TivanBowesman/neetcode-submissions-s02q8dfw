class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        //use pq

        Map<Integer,Integer> map = new HashMap<>();

        for(int num : nums){
            map.put(num,map.getOrDefault(num, 0) + 1);
        }

        PriorityQueue<int[]> pq = new PriorityQueue<>(
            //max heap
            (a,b) -> Integer.compare(b[0], a[0])
        );

        for(int key : map.keySet()){
            pq.add(new int[] {map.get(key), key});
        }

        int[] res = new int[k];
        for(int i = 0; i < k; i++){
            res[i] = (pq.poll()[1]);
        }

        return res;


    }
}
