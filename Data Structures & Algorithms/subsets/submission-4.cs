public class Solution {
    public List<List<int>> list;
    public List<List<int>> Subsets(int[] nums) {
        list = new List<List<int>>();
        backtrack(nums, new List<int>(), 0);
        return list;
    }

    public void backtrack(int[] nums, List<int> curr, int index ){
        if (index == nums.Length){
            list.Add(new List<int>(curr));
            return;
        } 

        //dont add
        backtrack(nums, curr, index + 1);

        //add 
        curr.Add(nums[index]);
        backtrack(nums, curr, index + 1);
        curr.RemoveAt(curr.Count - 1); 
    }
}
