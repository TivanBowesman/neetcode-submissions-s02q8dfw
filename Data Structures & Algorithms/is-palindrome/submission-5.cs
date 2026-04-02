public class Solution {
    public bool IsPalindrome(string s) {
        //reads the same forwards and backward
        //add to stack 
        //string s in reverse should be the peek

        var stack = new Stack<char>();

        foreach (char i in s){
            if(char.IsLetterOrDigit(i)){
                stack.Push(char.ToLower(i));
            }
        }
        //pop is in reverse already so loop through it normally
        for (int i = 0; i < s.Length; i++) {
            if (char.IsLetterOrDigit(s[i])) {
                if (stack.Pop() != char.ToLower(s[i])) {
                    return false;
                }
            }
        }


        return true;
    }
}
