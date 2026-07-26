public class Solution {
    public bool IsValid(string s) {
        var map = new Dictionary<char,char>(){
            ['}'] = '{',
            [')'] = '(',
            [']'] = '['
        };

        var stack = new Stack<char>();

        foreach(var c in s){
            if(!map.ContainsKey(c)){
                stack.Push(c);
    
            }else if(stack.Any()){
                if(stack.Pop() != map[c]) return false;
            }else{
                return false;
            }
        }

        
        return !stack.Any();
    }
}
