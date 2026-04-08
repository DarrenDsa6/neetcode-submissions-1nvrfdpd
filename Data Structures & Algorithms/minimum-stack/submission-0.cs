public class MinStack {
    private Stack<int> stack;
    private Stack<int> min;

    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(min.Count == 0 || val <= min.Peek()){
            min.Push(val);
        }
    }
    
    public void Pop() {
        if (stack.Count == 0) return;
        int del = stack.Pop();
        if(del==min.Peek()){
            min.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
