public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        /*
        store value in map and check to see if the value is present 
        to avoid dupes with ContainsValue
        */
        
        //two pointer 
        //sort list
        Array.Sort(nums);
        var list = new List<List<int>> ();

        for(int i = 0; i < nums.Length - 2; i++){
            //placeholder index
            //break since its impossible to get 0 if the array has been sorted
            if(nums[i] > 0) break;
            //move index along for unique value
            if (i > 0){
                if (nums[i]==nums[i-1]){
                    continue;
                }
            }
            //start left above placeholder {i,L,x,x,R}
            int left = i+1;
            int right = nums.Length - 1;
            while (left < right){
                //try find i + right + left that equals = 0
                //add to list
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0){
                    list.Add(new List<int> {nums[i],nums[left],nums[right]});
                    left++;
                    right--;
                    while (left < right && nums[left] == nums[left-1]){
                        left++;
                    }
                }else if(sum < 0){
                    left++;
                }else{
                    right--;
                }
            }
        }

        return list; 


    }
}
