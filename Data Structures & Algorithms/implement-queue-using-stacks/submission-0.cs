public class MyQueue {
    Stack<int> stack;
    public MyQueue() {
        stack = new Stack<int>( );
    }
    
    public void Push(int x) {
        //place items behind the currlist
        var list = new List<int>();
        while(stack.Any()){
            list.Add(stack.Pop());
        }

        stack.Push(x);
        
        while(list.Any()){
            int index = list.Count - 1;
            stack.Push(list[index]);
            list.RemoveAt(index);
             
        }
        
    }
    
    public int Pop() {
        return stack.Pop( ); 
    }
    
    public int Peek() {
        return stack.Peek(); 
    }
    
    public bool Empty() {
        return !stack.Any( ); 
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */