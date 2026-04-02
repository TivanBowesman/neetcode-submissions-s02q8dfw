public class Solution {
    public bool IsValid(string s) {
        //add to stack and it should unwind itself naturally
        //if key in map pop
        // if pop mpa - key return false;
        //closing keys
        var stack = new Stack<char>();
        var map = new Dictionary<char, char> {
            { '}', '{' },
            { ')', '(' },
            { ']', '[' }
        };



        foreach(var i in s ){
            if(map.ContainsKey(i)){
                if(!stack.Any()) return false; 
                var pop = stack.Pop();
                if (pop != map[i]) return false;
            }else{
                stack.Push(i);
            }

            
        }

        return !stack.Any(); 
    }
}
