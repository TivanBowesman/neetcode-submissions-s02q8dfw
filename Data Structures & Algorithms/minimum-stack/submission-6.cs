public class MinStack {
    Stack<int> stack1;
    Stack<int> minstack;
    public MinStack() {
        minstack = new Stack<int>( );
        stack1 = new Stack<int>( );
    }
    
    public void Push(int val) {
        stack1.Push(val);

        if(minstack.Count == 0 || minstack.Peek() >= val ){
            minstack.Push(val);
        }

        
    }
    
    public void Pop() {
        if (stack1.Peek() == minstack.Peek()){
            stack1.Pop();
            minstack.Pop();
            return;        
        }

        stack1.Pop();

        
    }
    
    public int Top() {
        return stack1.Peek();
    }
    
    public int GetMin() {
        return minstack.Peek();
    }
}
