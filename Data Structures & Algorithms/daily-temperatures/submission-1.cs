public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //init array of length(temperatures)
        var arr = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length;i++ ){
            int day = temperatures[i];
            while(!(stack.Count==0) && temperatures[stack.Peek()] < day ){
                int prevDay = stack.Pop();
                arr[prevDay] = i - prevDay ; 
            }
            stack.Push(i);
        }

        return arr;
    }
}
