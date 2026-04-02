public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var list = new List<List<int>>();

        backtrack(0,nums,list,new List<int>());

        return list;
    }

    public void backtrack(int i, int[] nums, List<List<int>> list, List<int> sub){
        //edge case 
        if(i == nums.Length){
            list.Add(new List<int>(sub));
            return; 
        }

        //dont pick
        backtrack(i+1,nums,list,sub);

        //pick
        sub.Add(nums[i]);
        backtrack(i+1,nums,list,sub);
        //remove because we are backtracking to the previous call in the call stack
        sub.RemoveAt(sub.Count-1);
    }
}
