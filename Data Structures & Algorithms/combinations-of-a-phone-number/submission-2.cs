public class Solution {
    //accesible throughout the class
    private Dictionary<char,string> map = new Dictionary<char, string> {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" },
        { '0', "+" }
    };

    public List<string> LetterCombinations(string digits) {
        var list = new List<string>();
        if (digits.Length == 0) return list;
        backtrack(0,list,new List<char>(), digits);
        return list;
    }

    public void backtrack(int i, List<string> list, List<char> sub, string digits){
        if (sub.Count == digits.Length){
            list.Add(new string(sub.ToArray()));
            return;
        }

        //pick 
        foreach(char c in map[digits[i]]){
            sub.Add(c);
            backtrack(i+1,list,sub,digits);
            sub.RemoveAt(sub.Count - 1);
        }
    }
}
