public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0)
            return false;

        Stack<char> stack = new Stack<char>();
        foreach(char ch in s){
            if(ch == '(' || ch == '{' || ch == '[')
                stack.Push(ch);
            else{
                if(stack.Count() == 0)
                    return false;

                char top = stack.Pop();

                if(ch == ')' && top != '(' || ch == '}' && top != '{' 
                    || ch == ']' && top != '[')
                    return false;    
            }    
        }
        return stack.Count() == 0;
    }
}
