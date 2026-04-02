public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        //pick / dont pick pattern
        var list = new List<List<int>>();
        var sub = new List<int>();
        backtrack(0, nums, 0,target,list, sub);
        return list;

    }

    public void backtrack(int i, int[] nums, int csum,int target, List<List<int>> list, List<int> sub){
        //edge cases    
        if (csum == target){
            list.Add(new List<int>(sub));
            return; 
        }
        
        if(i == nums.Length || csum > target){
            return; 
        }
       
        
        //dont pick
        backtrack(i + 1, nums, csum,target, list, sub );

        //pick
        sub.Add(nums[i]);
        backtrack(i, nums, csum + nums[i],target,list, sub);
        sub.RemoveAt(sub.Count - 1);


    }
}
