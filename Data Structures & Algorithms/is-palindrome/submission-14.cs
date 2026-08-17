public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0; 
        int r = s.Length - 1;



        s = new string(s
        .Select(i => char.ToUpper(i))
        .ToArray());

        while(l < r){
            while(l < r && !char.IsLetterOrDigit(s[l]) ) l++;
            while(l < r && !char.IsLetterOrDigit(s[r])) r--;

            if(s[l] != s[r]) return false;
            l++;
            r--;
        }

        return true;
    }
}
