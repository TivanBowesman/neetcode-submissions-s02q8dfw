public class Solution {
    public int LongestConsecutive(int[] nums) {
        //work with unique elements
        var Set = new HashSet<int>(nums);
        int longest = 0;

        //lookup is O(1) constant time
        foreach (int i in Set){
            //check if set does NOT has a number smaller than the current element
            if (Set.Contains(i-1)==false){
                int length = 1;
                //increment length as long as a bigger element exist(+1)
                while(Set.Contains(i + length)){
                    length += 1;
                }

                longest = Math.Max(length, longest);
            }
        }

        return longest ;
    }
}
