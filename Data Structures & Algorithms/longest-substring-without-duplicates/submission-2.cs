public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0; 
        var hashset = new HashSet<char>();
        int l = 0;

        for(int r = 0; r < s.Length; r++){
            //remove the dupe 
            while(!hashset.Add(s[r])){
                //move the left until the dupe is removed
                hashset.Remove(s[l]); //removes the first instance of s[l]
                
                l++;
            }
            //add to the hashset
            hashset.Add(s[r]);
            max = Math.Max(r-l + 1,max );
        }

        return max;
    }
}
