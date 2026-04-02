public class Solution {
    public List<List<int>> Permute(int[] nums) {
        /*
            have a hashset
            check if set == nums.Length 
            loop edge is until sub == 3 

        */ 
        var list = new List<List<int>>();
 
        //hashset for quicklook up
        backtrack(nums,list,new HashSet<int>());
        return list;
    }

    public void backtrack(int[] nums, List<List<int>> list,HashSet<int> hashset){
        //edge case
        if (hashset.Count == nums.Length){
            list.Add(new List<int>(hashset));
            return;
        }
        //pick
        //1 recusive stack
        //THEN 
        //2 recursive stack
        
        foreach(int num in nums){
            if(!hashset.Contains(num)){

                hashset.Add(num); 
                backtrack(nums,list,hashset);
                hashset.Remove(num);

            }
            //num 1 
            /*
                1
                new
                12
                13
                new
                123
                edge 
                12
                remove
            */
        }

    }
}
