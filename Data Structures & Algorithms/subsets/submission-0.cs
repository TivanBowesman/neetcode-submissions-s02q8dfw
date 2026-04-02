public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        // ,1,12,123,2,23,3,13
        // 2^3  = 8 combinations 
        var list = new List<List<int>>();
        var sub = new List<int>();

        //start at the first index
        backtrack(0,nums,list,sub);

        return list;
    }

    public void backtrack(int i,int[] nums, List<List<int>> list, List<int> sub){
        //edge case
        if (i == nums.Length){
            list.Add(new List<int>(sub));
            return;
        }

        //dont pick num 
        backtrack(i + 1,nums, list,sub);

        //pick num
        sub.Add(nums[i]);
        backtrack(i + 1,nums, list,sub);
        sub.RemoveAt(sub.Count - 1);
        

    }
}