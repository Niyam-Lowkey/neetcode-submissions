public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string st in tokens){
            if(st == "+"){
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if(st == "-"){
                int last = stack.Pop();
                int first = stack.Pop();
                stack.Push(first - last);
            }
            else if(st == "*"){
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if(st == "/"){
                int last = stack.Pop();
                int first = stack.Pop();
                stack.Push((int) ((double) first/last));
            }
            else{
                stack.Push(int.Parse(st));
            }
        }
        return stack.Pop();
    }
}
