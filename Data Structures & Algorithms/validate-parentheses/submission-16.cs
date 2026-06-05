public class Solution {
    public bool IsValid(string s) {
        // stack to track the open parentheis
        //edge case 
        
        var map = new Dictionary<char,char>(){
            ['}'] = '{',
            [']'] = '[',
            [')'] = '('
        };

        var stack = new Stack<char>();

        foreach(var c in s){
            //check if its an opening
            if(map.ContainsKey(c)){
                
                if(!stack.Any() || map[c] != stack.Pop()) return false;
            }else{
                //add opening to stack
                stack.Push(c);
            }


        }


        return !stack.Any();
    }
}
