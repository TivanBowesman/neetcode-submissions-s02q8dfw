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
       backtrack(0,new List<char>(),digits,list);
       return list; 
    }

    public void backtrack(int i, List<char> curr, string digit,List<string> list){
        //edge case
        if (curr.Count == digit.Length){
            list.Add(new string(curr.ToArray()));
            return;
        }

        //start with first digit of input digit
        foreach (char str in map[digit[i]]){
            curr.Add(str);
            backtrack(i + 1,curr ,digit,list);
            curr.RemoveAt(curr.Count - 1);
        }
    }

}
