public class Solution {
    public int Trap(int[] height) {
        var lWall = 0; 
        var rWall = 0;
        int len = height.Length; 
        var maxleft = new int[len];
        var maxright = new int[len];

        for (int i = 0; i < len; i++){
            int j = len - i - 1; //go in reverse
            maxleft[i] = lWall;
            maxright[j] = rWall;

            //update walls
            lWall = Math.Max(lWall, height[i]);
            rWall = Math.Max(rWall, height[j]);
        }

        int sum = 0;
        for(int i = 0; i < len; i++){
            int potential = Math.Min(maxleft[i],maxright[i]);
            sum += Math.Max(0, potential - height[i]);
        }

        return sum;
    }
}

//find len r - l ?
//h is math.min() of sidewalls

//if bigger than or equal to l get area
