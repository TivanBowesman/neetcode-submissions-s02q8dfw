public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var res = new int[nums.Length - k + 1];
        var list = new List<int>( );
        for(int i = 0; i < k; i++){
            list.Add(nums[i]);
        }

        int max = list.Max();
        res[0] = max;
        var index = 1;

        for(int i = k; i < nums.Length; i++){
            
            list.Add(nums[i]);

            list[i - k] = int.MinValue;

            res[index] = list.Max();

            index++; 
        }

        return res;
    }
}


//list 
//loop over
//each time you go move -> change the i - k to minvalue
//call max -> put in resat i


//use Priority queue?