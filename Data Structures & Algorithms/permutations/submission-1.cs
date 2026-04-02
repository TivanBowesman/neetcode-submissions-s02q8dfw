public class Solution {
    public List<List<int>> Permute(int[] nums) {
        /*
            have a hashset
            check if set == nums.Length 
            loop edge is until sub == 3 

        */ 
        var list = new List<List<int>>();
        var sub = new List<int>();
        //hashset for quicklook up
        backtrack(nums,list,sub,new HashSet<int>());
        return list;
    }

    public void backtrack(int[] nums, List<List<int>> list, List<int> sub,HashSet<int> hashset){
        //edge case
        if (sub.Count == nums.Length){
            list.Add(new List<int>(sub));
            return;
        }
        //pick
        foreach(int num in nums){
            if(!hashset.Contains(num)){
                hashset.Add(num); 
                sub.Add(num);
                backtrack(nums,list,sub,hashset);
                hashset.Remove(num);
                sub.RemoveAt(sub.Count - 1);
            }
        }

    }
}
