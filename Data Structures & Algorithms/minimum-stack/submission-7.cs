public class MinStack {
    Stack<int> stack;
    Stack<int> minstack;
    public MinStack() {
        stack = new Stack<int>();
        minstack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);

        if(!minstack.Any() || minstack.Peek() >= val){
            minstack.Push(val);
        }
    }
    
    public void Pop() {
        
        if(stack.Pop() == minstack.Peek()){
            minstack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minstack.Peek();
    }
}
