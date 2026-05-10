public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        //brute force 
        //map with k - num[i] v- index
        //if num in map check - if not valid change index 

        var map = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++){
            if(map.ContainsKey(nums[i])){
                var diffCheck = Math.Abs(map[nums[i]] - i) <= k;

                if (diffCheck){
                    return true;
                }
                //not be valid - change index
                map[nums[i]] = i;
            }else{
                //add num and its index
                map[nums[i]] = i;
            }
        }

        return false;
    }
}