public class Solution {
    public int LengthOfLongestSubstring(string s) {
        /*
            longest subarray with out duplicate characters
            sliding window
            move r if charcater is unseen in current window 
            move left while there are dupe characters
            max should be r - l or length of data structure/collection
        */
        int max = 0;
        int l = 0;
  

        var HashSet = new HashSet<char>();

        for (int r = 0; r < s.Length; r++){
            while(HashSet.Contains(s[r])){
                HashSet.Remove(s[l]);
                //move l
                l++;
            }
            
            HashSet.Add(s[r]);
            //calculate the max subarray length 
            max = Math.Max(max,HashSet.Count);
        }

        return max;
    }
}
