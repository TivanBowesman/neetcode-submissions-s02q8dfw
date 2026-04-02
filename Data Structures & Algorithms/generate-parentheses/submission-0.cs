public class Solution {

    public List<string> GenerateParenthesis(int n) {
        var list = new List<string>();
        string stack = "";
        Backtrack(0, 0, n, list, stack);
        return list;
    }



    public void Backtrack(int openN, int closedN, int n, List<string> res, string stack) {
        //BaseCase
        if (openN + closedN == 2*n ) {
            res.Add(stack);
            return;
        }

        if (openN < n) {
            Backtrack(openN + 1, closedN, n, res, stack + '(');
        }

        if (closedN < openN) {
            Backtrack(openN, closedN + 1, n, res, stack + ')');
        }
    }

}
//num of open brackets has to be >= closing brackets