public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var map = new Dictionary<char,int>();

        foreach(var c in s){
            if(map.ContainsKey(c)){
                map[c]++;
            }else{
                map[c] = 1;
            }
        }

        //decrement

        foreach(var c in t){
            if(!map.ContainsKey(c)){
                return false;
            }

            map[c]--;

            if(map[c] < 0) return false;
        }

        return true;
    }
}

//if char not in map return false
