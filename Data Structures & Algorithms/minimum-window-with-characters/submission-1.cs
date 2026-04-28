public class Solution {
    public string MinWindow(string s, string t) {
        //edge case
        if(s.Length < t.Length) return "";
        int l = 0;
        int min = int.MaxValue;
        var list = new List<char>();
        string res = "";

        for(int r = 0; r < s.Length; r++){
            var currChar = s[r];

            //add to list
            list.Add(currChar);

            while(check(t, list)){
                //valid
                int window = r - l + 1;
                if(window < min){
                    res = new string(list.ToArray());
                    //update window
                    min = window;     
                }

                //remove from left most
                list.RemoveAt(0);

                

                //shrink window
                l++;
            }


            
            
        }

        return res;
    }

    public bool check(string t, List<char> list){
        var available = new Dictionary<char, int>();
        //add to list
        foreach(char c in list)
            available[c] = available.GetValueOrDefault(c) + 1;

        //remove from list
        foreach(char c in t){
            if(!available.ContainsKey(c) || available[c] == 0)
                return false;
            available[c]--;
        }

        return true;
    }
}


//build up arr
//when all present take window size
//decrease until that is no longer valid
// move r 
//repeat until end
//create function that checks if all are contained