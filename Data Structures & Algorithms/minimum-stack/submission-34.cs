public class MinStack {

    private Stack<int> stack;
    private Stack<int> mainstack;
    public MinStack() {
         stack = new Stack<int>();
         mainstack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
         Console.WriteLine($"{mainstack.Count}");
         if(mainstack.Count == 0){
            mainstack.Push(val);            
         }
         else{
            int currentMin = Math.Min(mainstack.Peek(),val);
            mainstack.Push(currentMin);   
         }
    }
    
    public void Pop() {
        stack.Pop();
        mainstack.Pop();        
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
       return mainstack.Peek();
    }
}
