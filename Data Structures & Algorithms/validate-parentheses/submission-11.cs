public class Solution {
    public bool IsValid(string s) {
        //closing check if top of stack is correct openning

        var map = new Dictionary<char, char>(){
        ['}'] = '{',
        [']'] = '[',
        [')'] = '('
    };

        var stack = new Stack<char>();

        foreach (var c in s){
            if (map.ContainsKey(c)){
                //if stack is empty then its invalid 
                if(!stack.Any()) return false;
                //check top of stack
                if(stack.Pop() != map[c]) return false;
            }else{
                stack.Push(c);
            }


        }

        return !stack.Any();
    }
}
