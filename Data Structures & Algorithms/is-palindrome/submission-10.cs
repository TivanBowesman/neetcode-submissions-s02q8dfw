public class Solution {
    public bool IsPalindrome(string s) {
        //two pointers
        int l = 0; 
        int r = s.Length - 1; 

        while(l < r ){
            //,pbe pointers to be on letters
            while (l < r && !char.IsLetterOrDigit(s[r])){
                r--;
            }

            while (l < r && !char.IsLetterOrDigit(s[l])){
                l++;
            }

            if(!char.ToLower(s[l]).Equals(char.ToLower(s[r]))){
                return false;
            }

            l++;
            r--;
        }

        return true;

        
    }
}
