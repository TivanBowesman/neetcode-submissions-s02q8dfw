public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var map = new Dictionary<char,char>(){
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach(char i in s){
            //pushes only opening parenthesis onto stack 
            if (map.ContainsValue(i)){
                stack.Push(i);
            }
            //checks to see if closing parenthesis match what is currently being popped
            /*
            if a closing parenthesis is being added then the stack SHOULD be 0 
            (because only openings are added)
            */
            else if(map.ContainsKey(i)){
                if(stack.Count == 0 || stack.Pop() != map[i]){
                    return false;
                }
            }
        }
        return stack.Count == 0;
        
    }
}
