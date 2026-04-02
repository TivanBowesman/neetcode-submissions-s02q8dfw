public class Solution {
    public int EvalRPN(string[] tokens) {
        //parse to int 
        //Math.Truncate(decimalNumber)
        var stack = new Stack<int>();

        foreach (string i in tokens){
            int num;
            if (int.TryParse(i, out num)){
                stack.Push(num);
            }else{
                // you want b to be the top of stack to preserve operation order
                int b = stack.Pop();
                int a = stack.Pop();

                switch (i){
                    case "+":
                        stack.Push(a + b);
                        break;
                    case "-":
                        stack.Push(a - b);
                        break;
                    case "*":
                        stack.Push(a * b);
                        break;
                    case "/":
                        stack.Push(a / b); // Integer division
                        break;
                }
            }
        }
        return stack.Pop();

    }
}
