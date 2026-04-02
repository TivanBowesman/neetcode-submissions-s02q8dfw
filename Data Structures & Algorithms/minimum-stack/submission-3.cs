public class MinStack {
    private Stack<int> stack;
    private Stack<int> min;

    //constructor  
    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);

        //only add the smallest to the top of the stack after first push
        if (min.Count == 0 || val <= min.Peek()){
            min.Push(val);
        }

    }
    
    public void Pop() {
        if(stack.Peek() == min.Peek()){
            min.Pop();
        }
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        //top of min SHOULD be the smallest
        return min.Peek();
    }
}
