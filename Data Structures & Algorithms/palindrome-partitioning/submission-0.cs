public class Solution {
    public List<List<string>> Partition(string s) {
        var list = new List<List<string>>();
        backtrack(0,s,list,new List<string>());
        return list;
    }

    public void backtrack(int i,string s, List<List<string>> list, List<string> sub){
        //edge cases 
        if (i == s.Length){
            list.Add(new List<string>(sub));
            return;
        }

        // try all possible substrings starting at "start"
        for (int end = i; end < s.Length; end++) {
            string substr = s.Substring(i, end - i + 1);

            if (palindrome(substr)) {
                sub.Add(substr);                 // choose
                backtrack(end + 1, s, list, sub); // explore
                sub.RemoveAt(sub.Count - 1); // un-choose (backtrack)
            }
        }
    }
    //confirm if its a palindrome
    public bool palindrome(string i){
        int l = 0;
        int r = i.Length - 1;

        while(l < r){
            if (i[l] != i[r]) return false;
            l++;
            r--;
        }
        return true;
    }

}
