public class Solution {
    public int EvalRPN(string[] tokens) {
        //the equation is always valid
        var stack = new Stack<int>();

        foreach(var i in tokens){
            if(i.Equals("+")){
                stack.Push(stack.Pop() + stack.Pop());

            }else if(i.Equals("-")){
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(a - b);

            }else if(i.Equals("*")){
                stack.Push(stack.Pop() * stack.Pop());

            }else if (i.Equals("/")){
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(a / b);

            }else{
                //must be a number
                stack.Push(int.Parse(i));
            }

            
            
        }

        return stack.Peek( );
    }
}
