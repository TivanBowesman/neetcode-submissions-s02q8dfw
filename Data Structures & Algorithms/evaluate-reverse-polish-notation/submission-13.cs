public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach(var s in tokens){
            if(int.TryParse(s, out int num )){
                stack.Push(num);
            }else if(s == "+"){
                stack.Push(stack.Pop() + stack.Pop());
            }else if(s == "*"){
                stack.Push(stack.Pop() * stack.Pop());
            }else if(s == "-"){
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(num2 - num1);
            }else{
                //division
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                stack.Push(num2 / num1);
            }

        }

        return stack.Peek();
    }
}
