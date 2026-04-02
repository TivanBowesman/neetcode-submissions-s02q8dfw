public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0) return true;

        //stack to keep tracjk of whats added
        var stack = new Stack<int>();

        var map = new Dictionary<char,char>(){
            {'}','{'},
            {']','['},
            {')','('}
        };

        foreach (char parenthesis in s){
            //push opening parenthesis onto stack 
            if (map.ContainsValue(parenthesis)){
                stack.Push(parenthesis);

            }else if( map.ContainsKey(parenthesis) ){
                //if stack is empty or the parenthesis dont match return false
                if(!(stack.Any()) || stack.Pop() != map[parenthesis]){
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
