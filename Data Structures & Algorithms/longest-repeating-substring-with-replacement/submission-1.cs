public class Solution {
    public int CharacterReplacement(string s, int k) {
        /*
            make l = r at the beginning
            introduce frequency array
            (int)char returns Ascii value
            get the char count in the given window and replace lowest 
        */
        int longest = 0;
        //array to store frequencies of characters(lowercase)
        var arr = new int[26];
        int l = 0; 
        s = s.ToUpper();
        for (int r = 0; r < s.Length; r++){
            
            arr[(s[r] - 'A')] += 1;
             
            //is window valid? 
            // k is number of replacements
            int maxFreq = arr.Max();
            while((r - l + 1) - maxFreq > k){
                arr[s[l] - 'A']--;
                l++;
                maxFreq = arr.Max();
            }
            
            longest = Math.Max(longest,r - l + 1);
        } 
        return longest;
    }
}
/*
    window is valid if k is less than WindowLength(r - l) - maximum char frequency
                                        
*/