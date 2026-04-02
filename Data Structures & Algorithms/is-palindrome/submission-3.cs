public class Solution {
    public bool IsPalindrome(string s) {
        //edge case
        if (s.Length <= 1){
            return true;
        }
        var SArray = s.ToCharArray();
        //beginning of string
        int LeftPointer = 0;
        //end of string 
        int RightPointer = s.Length - 1;
        
        while(LeftPointer < RightPointer){
            while (LeftPointer < RightPointer && !char.IsLetterOrDigit(SArray[LeftPointer])) {
                LeftPointer++;
            }
            while (LeftPointer < RightPointer && !char.IsLetterOrDigit(SArray[RightPointer])) {
                RightPointer--;
            }

            if (!char.ToLower(SArray[LeftPointer]).Equals(char.ToLower(SArray[RightPointer]))) {
                return false;
            }

            // Move pointers
            LeftPointer++;
            RightPointer--;
        }
        //return true if you pass the 
        return true;
    }
}
