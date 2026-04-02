public class Solution {
    public bool IsPalindrome(string s) {
        // use left and right pointers to look over the word
        // meet in the middle 

        int l = 0; 
        int r = s.Length - 1; 

        while (l < r){
            //is letter or digit
            if(!char.IsLetterOrDigit(s[l])){
                while(l < r && char.IsLetterOrDigit(s[l]) == false ){
                    l++;
                }
            }
            if(!char.IsLetterOrDigit(s[r])){
                while(l < r && char.IsLetterOrDigit(s[r]) == false ){
                    r--;
                }

            }

            if( Char.ToLower(s[l]) == Char.ToLower(s[r])){
                //increment/decrememnt
                l++;
                r--;
            }else{
                return false; 
            }
        }
        return true;
    }
}
