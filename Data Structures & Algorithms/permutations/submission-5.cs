public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var list = new List<List<int>>();
        backtrack(nums, list, new List<int>());
        return list; 
    }

    public void backtrack(int[] nums,List<List<int>> list, List<int> sub){
        //edge case
        if (sub.Count == nums.Length){
            list.Add(new List<int>(sub));
            return;
        }

        //each loop is its own call stack 
        foreach (int num in nums){
            if(!sub.Contains(num)){
                sub.Add(num);
                backtrack(nums,list,sub);
                //remove the end of list 
                sub.RemoveAt(sub.Count - 1);
            }
        }
    }
}
