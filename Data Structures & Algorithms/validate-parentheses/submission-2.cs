public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var map = new Dictionary<char,char>(){
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach(char i in s){
            if (map.ContainsValue(i)){
                stack.Push(i);
            }
            else if(map.ContainsKey(i)){
                if(stack.Count == 0 || stack.Pop() != map[i]){
                    return false;
                }
            }
        }
        return stack.Count == 0;
        
    }
}
