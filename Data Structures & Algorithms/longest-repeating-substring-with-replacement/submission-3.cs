public class Solution {
    public int CharacterReplacement(string s, int k) {
        //make use of formula 
        //window size - maxfreqchar < k

        //max freq array
        int n = s.Length;
        var arr = new int[26];
        int longest = 0;
        int l = 0; 
        for (int r = 0; r < n; r++){
            //update freq array
            arr[s[r] - 'A']++;
            int windowSize = r - l + 1; //base 0

            while(windowSize - arr.Max() > k ){
                //remove(decrement) what was at l
                arr[s[l] - 'A']--;
                //move l
                l++;
                //update window for longest calulation
                windowSize = r - l + 1;
            }

            longest = Math.Max(windowSize, longest);
        }

        return longest;
        
    }
}
