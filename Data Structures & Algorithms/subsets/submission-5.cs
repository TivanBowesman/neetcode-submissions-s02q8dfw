public class Solution {
    int max;
    public List<List<int>> Subsets(int[] nums) {
        //dont pick
        //pick
        max = nums.Length;

        var list = new List<List<int>>();
        helper(0,list,new List<int>(), nums); 
        return list;
    }

    public void helper(int index, List<List<int>> list, List<int> curr, int[] nums){
        if (index == max){
            list.Add(new List<int>(curr));
            return;
        }

        //dont pick
        helper(index + 1, list, curr, nums);
        //pick
        curr.Add(nums[index]);
        helper(index + 1, list, curr, nums);
        curr.RemoveAt(curr.Count - 1);
    }
}
