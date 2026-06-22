public class Solution {
    public int[] DailyTemperatures(int[] temp) {
        //(temp, index)
        var len = temp.Length;
        var arr = new int[len];
        Array.Fill(arr, 0);
        var stack = new Stack<(int,int)>();

        for(int i = 0; i < len; i++){
            while(stack.Count != 0 && temp[i] > stack.Peek().Item1 ){
                var item = stack.Pop(); 
                arr[item.Item2] = i - item.Item2;
            }
            stack.Push( (temp[i], i) );
        }
        return arr;        
    }

}

// if top of stack is lower than next
//temp[index] = i - stack.Pop().Item2;
