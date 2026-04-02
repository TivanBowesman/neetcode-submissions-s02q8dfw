public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var match = new Dictionary<char, char>(){
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char i in s){
            if (match.ContainsValue(i)){
                stack.Push(i);
            }
            else if (match.ContainsKey(i)){
                if (stack.Count == 0 || stack.Pop() != match[i]){
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
