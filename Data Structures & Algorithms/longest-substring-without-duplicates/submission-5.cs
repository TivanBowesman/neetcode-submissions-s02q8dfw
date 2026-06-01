public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //sliding window

        //l r
        int maxSubString = 0;
        int l = 0;
        
        var hashset = new HashSet<char>();
        for(int r = 0; r < s.Length; r++){
            int window = r - l + 1;

            //check if present 
            if(!hashset.Add(s[r])){
                while(hashset.Contains(s[r])){
                    hashset.Remove(s[l]);
                    l++;
                    //update the window
                    window = r - l + 1;
                
                }   
            }

            hashset.Add(s[r]);


            maxSubString = Math.Max(maxSubString, window);
        }

        return maxSubString;
    }
}
