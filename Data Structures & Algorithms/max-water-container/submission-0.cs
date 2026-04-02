public class Solution {
    public int MaxArea(int[] heights) {
        //find the two biggest values 
        // find the biggest differnce between thier indexes in the array 
        //length is index diff - Height is smaller of the tow biggest found
        int area = 0;
        
        for (int i = 0; i < heights.Length ; i++){
            for (int j = i+1; j < heights.Length ; j++){           
                //get height and length separatlety for modularity 
                int length = j - i;               
                int height = Math.Min(heights[i],heights[j]);

                area = Math.Max(area,length * height);
            }
        }

        return area;
        
    }
}
