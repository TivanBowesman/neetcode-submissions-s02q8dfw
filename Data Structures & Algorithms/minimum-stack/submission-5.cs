public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        //only push to min if its smaller than the prev or count is 0

        stack.Push(val);

        if (minStack.Count == 0 || minStack.Peek() >= val){
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (stack.Peek( ) == minStack.Peek( )){
            minStack.Pop();
            stack.Pop();
        }else{
            stack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
