public class Solution {
    public bool IsPalindrome(string s) {
        //two pointers 
        // continue checkning until they meet 

        int l = 0;
        int r = s.Length - 1;

        //if not alpha num skip
        while( l < r ){
            //check if alpha num 
            while (l < r && !Char.IsLetterOrDigit(s[l])){
                l++;
            }

            while (l < r && !Char.IsLetterOrDigit(s[r])){
                r--;
            }
            //compare
            if (Char.ToLower(s[l]) != Char.ToLower(s[r])){
                return false; 
            }
            
            l++;
            r--;
        }
        return true; 
    }
}
