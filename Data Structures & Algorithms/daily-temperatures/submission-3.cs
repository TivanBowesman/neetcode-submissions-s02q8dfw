public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //store the temp and its index
        //(int, int) item1, item2
        int len = temperatures.Length;
        var stack = new Stack<(int,int)>();
        var res = new int[len];

        for(int i = 0; i < len; i++){
            var curr = temperatures[i];

            while(stack.Any() && temperatures[stack.Peek().Item2] < curr){
                var index = stack.Pop().Item2;

                res[index] = i - index; 
            }

            stack.Push((temperatures[i], i));
        }
        //curr index - previndex

        return res;
        
    }
}
