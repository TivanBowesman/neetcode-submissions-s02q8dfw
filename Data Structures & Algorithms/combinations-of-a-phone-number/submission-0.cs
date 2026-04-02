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
       backtrack(0,"",digits,list);
       return list; 
    }

    public void backtrack(int i, string curr, string digit,List<string> list){
        //edge case
        if (curr.Length == digit.Length){
            list.Add(curr);
            return;
        }

        //start with first digit of input digit
        foreach (char str in map[digit[i]]){
            backtrack(i + 1,curr + str,digit,list);
        }
    }

}
