public class Solution {
    public int LastStoneWeight(int[] stones) {
        //implement max heap
        //get top two (while count > 1)
        //calulate the weight
        //insert new weight into maxheap 
        //continue until count <= 1

        var maxheap = new PriorityQueue<int,int>();

        //add items to the heap
        foreach (int stone in stones){
            maxheap.Enqueue(stone, -stone);
        }

        //grab top two 
        while(maxheap.Count > 1){
            int stone1 = maxheap.Dequeue();
            int stone2 = maxheap.Dequeue();

            if(!(stone1 == stone2)){
                //stone 1 will be the bigger one since it is a MAXHEAP
                int newstone = stone1 - stone2;
                maxheap.Enqueue(newstone, -newstone);
            }
        
        }
        if (maxheap.Count < 1) return 0; 

        return maxheap.Peek();
    }
}
