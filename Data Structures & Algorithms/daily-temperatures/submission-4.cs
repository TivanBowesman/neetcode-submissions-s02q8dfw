public class Solution {
    public int[] DailyTemperatures(int[] temp) {
        var stack = new Stack<int>();
        var len = temp.Length;
        var res = new int[len];

        for (int i = 0; i < len; i++) {
            var curr = temp[i];

            while (stack.Count != 0 && temp[stack.Peek()] < curr) {
                var now = stack.Pop();

                res[now] = i - now;
            }

            // index - index(0)
            stack.Push(i);
        }

        return res;
    }
}
