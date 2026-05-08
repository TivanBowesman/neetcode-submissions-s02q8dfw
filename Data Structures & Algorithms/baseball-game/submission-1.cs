public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        foreach (var s in operations) {
            if (s == "+") {
                var x = stack.Pop();
                var y = stack.Pop();
                var sum = x + y;
                stack.Push(y);
                stack.Push(x);
                stack.Push(sum);
            }
            else if (s == "D") {
                stack.Push(stack.Peek() * 2);
            }
            else if (s == "C") {
                stack.Pop();
            }
            else {
                stack.Push(int.Parse(s));
            }
        }

        return stack.Sum();
    }
}