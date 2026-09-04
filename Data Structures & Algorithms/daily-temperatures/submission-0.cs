public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int[] answer = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();

        for(int i = 0 ; i < temperatures.Length; i++){

            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]){
                int prevlength = stack.Pop();
                answer[prevlength] = i - prevlength;
            }
            stack.Push(i);
        }

        return answer;
        
    }
}
