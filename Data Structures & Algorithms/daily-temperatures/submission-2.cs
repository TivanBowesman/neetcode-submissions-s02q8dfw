public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>( );
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++){

            var current = temperatures[i];

            while(stack.Any() &&  temperatures[stack.Peek()] < current){
                var now = stack.Pop(); //takes the index

                result[now] =  i - now;

            }

            stack.Push(i);

            /*
                [6,7] stack
                [1, 4, 1, 2, 1, 0 ,0]arr 
                [1, 4, 1, 2, 1, 0 ,0]
                [0, 1, 2 ,3, 5, 6 ,7]index
                30
                40,28

            */
        }

        return result;

    }
}
